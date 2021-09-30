using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstModel.Models
{
    public class BlogContext : DbContext
    {
        protected BlogContext(DbContextOptions<BlogContext>options)
            : base (options)
        {
        }
    }
}
