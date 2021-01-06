using DotNetPatterns.Specification.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.Specification.Movies
{
    public class MovieRepository : IMovieRepository
    {
        private List<Movie> Movies { get; set; }

        public MovieRepository()
        {
            Movies = new List<Movie>();
        }

        public IEnumerable<Movie> Get(Specification<Movie> specification) 
            => Movies.AsQueryable().Where(specification.ToExpression());
    }
}
