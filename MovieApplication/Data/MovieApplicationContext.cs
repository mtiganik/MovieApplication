using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MovieApplication.Models
{
    public class MovieApplicationContext : DbContext
    {
        public MovieApplicationContext (DbContextOptions<MovieApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<MovieApplication.Models.Movie> Movie { get; set; }
    }
}
