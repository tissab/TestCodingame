using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodingame.SaveChange
{
    class Save_EntityFramework
    {
        public async Task<bool> SaveOrder(Order order) 
        {
            using (var context = new ApplicationDbContext())
            {
                context.Order.Add(order);
                context.SaveChanges();
                return true;
            }
        }
    }

    class Order
    {

    }

    class ApplicationDbContext : DbContext
    {
        public DbSet<Order>? Order { get; set; }
    }
}
