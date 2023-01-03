using System;
using System.Data.Entity;
using System.Threading.Tasks;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

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
