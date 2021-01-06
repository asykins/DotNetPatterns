using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.Specification.Specifications
{
    public abstract class Specification<T>
    {
        public abstract Expression<Func<T, bool>> ToExpression();

        public bool IsSatisfiedBy(T entity)
            => ToExpression().Compile()(entity);

        public bool AreSatisfiedBy(IEnumerable<T> entities)
        {
            foreach(var entity in entities)
            {
                if (!IsSatisfiedBy(entity))
                    return false;
            }

            return true;
        }

        public Specification<T> And(Specification<T> specification)
            => new AndSpecification<T>(this, specification);

        public Specification<T> Or(Specification<T> specification)
            => new OrSpecification<T>(this, specification);
    }

    public class AndSpecification<T> : Specification<T>
    {
        private readonly Specification<T> left;
        private readonly Specification<T> right;

        public AndSpecification(Specification<T> left, Specification<T> right)
        {
            this.left = left ?? throw new ArgumentNullException(nameof(left));
            this.right = right ?? throw new ArgumentNullException(nameof(right));
        }

        public override Expression<Func<T, bool>> ToExpression()
            => Expression.Lambda<Func<T, bool>>(Expression.AndAlso(left.ToExpression(), right.ToExpression()), left.ToExpression().Parameters.First());
    }

    public class OrSpecification<T> : Specification<T>
    {
        private readonly Specification<T> left;
        private readonly Specification<T> right;

        public OrSpecification(Specification<T> left, Specification<T> right)
        {
            this.left = left ?? throw new ArgumentNullException(nameof(left));
            this.right = right ?? throw new ArgumentNullException(nameof(right));
        }

        public override Expression<Func<T, bool>> ToExpression()
            => Expression.Lambda<Func<T, bool>>(Expression.Or(left.ToExpression(), right.ToExpression()), left.ToExpression().Parameters.First());
    }
}
