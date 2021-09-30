using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Models;

namespace ProyectoFinal.Data
{
    public class PryectoFinalContext : DbContext
    {
        public PryectoFinalContext (DbContextOptions<PryectoFinalContext> options)
            : base(options)
        {
        }

        public DbSet<ProyectoFinal.Models.Plato> Plato { get; set; }

        public DbSet<ProyectoFinal.Models.Ingredientes> Ingredientes { get; set; }
    }
}
