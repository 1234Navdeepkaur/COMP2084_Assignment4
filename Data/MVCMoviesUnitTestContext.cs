using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCMoviesUnitTest.Models;

namespace MVCMoviesUnitTest.Data
{
    public class MVCMoviesUnitTestContext : DbContext
    {
        public MVCMoviesUnitTestContext (DbContextOptions<MVCMoviesUnitTestContext> options)
            : base(options)
        {
        }

        public DbSet<MVCMoviesUnitTest.Models.Movie> Movie { get; set; } = default!;
    }
}
