using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MenuListo.Models;

namespace MenuListo.Data
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<MenuListo.Models.Plato> Plato { get; set; }

        public DbSet<MenuListo.Models.IngredienteP> IngredienteP { get; set; }
    }
}
