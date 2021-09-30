using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using dddd.Models;

namespace dddd.Data
{
    public class ddddContext : DbContext
    {
        public ddddContext (DbContextOptions<ddddContext> options)
            : base(options)
        {
        }

        public DbSet<dddd.Models.Movie> Movie { get; set; }
    }
}
