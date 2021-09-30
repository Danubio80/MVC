using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using bddatos.Models;

namespace bddatos.Data
{
    public class bddatosContext : DbContext
    {
        public bddatosContext (DbContextOptions<bddatosContext> options)
            : base(options)
        {
        }

        public DbSet<bddatos.Models.clientes> clientes { get; set; }
    }
}
