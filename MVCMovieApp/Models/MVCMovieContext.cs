using System;
using Microsoft.EntityFrameworkCore;

namespace MVCMovieApp.Models
{
    public class MVCMovieContext : DbContext
    {
        public MVCMovieContext(DbContextOptions<MVCMovieContext> options) :base(options)
        {
        }

        public DbSet<MVCMovieApp.Models.Movie> Movies { get; set; }
    }
}
