using DotNetPatterns.Specification.Specifications;
using System.Collections.Generic;

namespace DotNetPatterns.Specification.Movies
{
    public interface IMovieRepository
    {
        public IEnumerable<Movie> Get(Specification<Movie> specification);
    }
}
