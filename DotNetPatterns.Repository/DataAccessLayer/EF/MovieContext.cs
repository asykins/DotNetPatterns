using DotNetPatterns.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPatterns.Repository.DataAccessLayer.EF
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions options)
            : base(options) { }

        DbSet<Movie> Movies { get; set; }
    }
}
