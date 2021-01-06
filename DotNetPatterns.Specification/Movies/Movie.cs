using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.Specification.Movies
{
    public class Movie
    {
        public string Title { get; set; }
        public MovieRating Rating { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
