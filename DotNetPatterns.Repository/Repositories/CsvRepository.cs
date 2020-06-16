using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;

namespace DotNetPatterns.Repository.Repositories
{
    public abstract class CsvRepository<T> : IRepository<T>
    {
        private readonly IEnumerable<T> Set;

        public CsvRepository(string sourceFile)
        {
            this.Set = File.ReadAllLines(sourceFile)
                                .Select(x => Map(x.Split(';')));
        }

        public IEnumerable<T> AggregateWherePredicates
            (IEnumerable<T> source, Expression<Func<T, bool>>[] predicates)
            => predicates.Aggregate(source, (currentSource, predicate) => currentSource.Where(predicate.Compile()));

        public IReadOnlyList<T> Find(params Expression<Func<T, bool>>[] predicates)
            => AggregateWherePredicates(this.Set, predicates).ToList();

        public abstract T Map(string[] splittedLines);
    }
}
