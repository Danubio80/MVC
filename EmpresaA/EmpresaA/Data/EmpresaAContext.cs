using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EmpresaA.Models;

namespace EmpresaA.Data
{
    public class EmpresaAContext : DbContext
    {
        public EmpresaAContext (DbContextOptions<EmpresaAContext> options)
            : base(options)
        {
        }

        public DbSet<EmpresaA.Models.cliente> cliente { get; set; }
    }
}
