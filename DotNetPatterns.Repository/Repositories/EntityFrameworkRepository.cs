using DotNetPatterns.Repository.DataAccessLayer.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DotNetPatterns.Repository.Repositories
{
    public abstract class EntityFrameworkRepository<T> : IRepository<T>
        where T: class
    {
        private readonly MovieContext _context;

        public EntityFrameworkRepository(MovieContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        private IQueryable<T> AggregateWhereExpressions
            (IQueryable<T> query, Expression<Func<T, bool>>[] predicates)
                => predicates.Aggregate(query, (currentQuery, predicate) 
                    => currentQuery.Where(predicate));

        public IReadOnlyList<T> Find(params Expression<Func<T, bool>>[] predicates)
        {
            return AggregateWhereExpressions(_context.Set<T>(), predicates).ToList();
        }
    }
}
