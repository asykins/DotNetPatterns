using DotNetPatterns.Specification.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.Specification.Specifications
{
    public class RatingSpecification : Specification<Movie>
    {
        private readonly MovieRating MovieRating;

        public RatingSpecification(MovieRating movieRating) 
            => (MovieRating) = (movieRating);

        public override Expression<Func<Movie, bool>> ToExpression()
            => movie => movie.Rating <= MovieRating;

        public static RatingSpecification ChildOnlyMovies()
            => new RatingSpecification(MovieRating.ForEveryOne);

        public static RatingSpecification AdultOnlyMovies()
            => new RatingSpecification(MovieRating.AdultOnly);
    }
}
