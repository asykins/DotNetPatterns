using DotNetPatterns.Specification.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.Specification.Specifications
{
    public class OlderMovieSpecification : Specification<Movie>
    {
        private readonly DateTime releaseDate;

        public OlderMovieSpecification(DateTime releaseDate)
            => (this.releaseDate) = (releaseDate);

        public override Expression<Func<Movie, bool>> ToExpression()
            => movie => movie.ReleaseDate <= releaseDate;
    }
}
