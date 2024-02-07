using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationAssessment7feb.Models;

namespace WebApplicationAssessment7feb.Data
{
    public class MovieDbContext : DbContext
    {
        public MovieDbContext (DbContextOptions<MovieDbContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationAssessment7feb.Models.Movie> Movie { get; set; } = default!;
    }
}
