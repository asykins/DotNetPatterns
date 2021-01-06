using DotNetPatterns.Specification.Movies;
using DotNetPatterns.Specification.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DotNetPatterns.Specification
{
    class Program
    {
        static void Main(string[] args)
        {
            var oldMovie = new OlderMovieSpecification(DateTime.Now.AddYears(-10));
            var childMovies = RatingSpecification.ChildOnlyMovies();

            var oldMoviesForKids = new MovieRepository().Get(oldMovie.And(childMovies));

            if (oldMovie.And(childMovies).AreSatisfiedBy(oldMoviesForKids))
                Console.WriteLine("Ok ! Let's watch the movies with the kiddos");
        }
    }
}
