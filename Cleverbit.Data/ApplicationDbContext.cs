using Cleverbit.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleverbit.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() :
          base("DefaultConnection")
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
