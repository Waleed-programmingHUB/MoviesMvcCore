using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoviesMvcCore.Models;

namespace MoviesMvcCore.Data
{
    public class MoviesMvcCoreContext : DbContext
    {
        public MoviesMvcCoreContext (DbContextOptions<MoviesMvcCoreContext> options)
            : base(options)
        {
        }

        public DbSet<MoviesMvcCore.Models.Movie> Movie { get; set; } = default!;
    }
}
