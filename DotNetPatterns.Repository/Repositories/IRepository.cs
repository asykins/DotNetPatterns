using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DotNetPatterns.Repository.Repositories
{
    public interface IRepository<T>
    {
        IReadOnlyList<T> Find(params Expression<Func<T, bool>>[] predicates);
    }
}
