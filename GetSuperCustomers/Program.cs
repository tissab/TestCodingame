using System;
using System.Collections.Generic;
using System.Linq;

namespace GetSuperCustomers
{
    class Order
    {
        public string Customer { get; set; }
        public decimal Price { get; set; }  
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             class Order
             {
                public string Customer { get; set; }
                public decimal Price { get; set; }  
             }

             GetSuperCustomers devra retourner une énumération de nom de clients à partir de
             la liste orders passée en paramètre.
             Seules les clients "moyens" nous interessent, sachant qu'un client de ce type
             est un client qui a dépensé au moins 100 euro mais moins de 300 euro. Attention:
             un même client peut avoir effectué plusieurs commandes. Essayez de prendre en compte
             cette éventualité

             Implémentez la methode GetSuperCustomers en utilisant LINQ. Comme présenté dans le code
             de test, votre solution devra fonctionner si la liste orders est modifiée après l'appel
             à la méthode GetSuperCustomers  (ne pas utiliser ToList()).
            */

            var orders = new List<Order>();
            orders.Add(new Order { Customer = "C3", Price = 150m });
            orders.Add(new Order { Customer = "C3", Price = 150m });
            orders.Add(new Order { Customer = "C2", Price = 31m });
            orders.Add(new Order { Customer = "C2", Price = 99m });
            orders.Add(new Order { Customer = "C1", Price = 50m });
            orders.Add(new Order { Customer = "C1", Price = 25m });

            var superCustomer = GetSuperCustomers(orders);

            foreach (var item in superCustomer) Console.WriteLine(item);
        }

        static IEnumerable<string> GetSuperCustomers(List<Order> orders)
        {
            //return orders.GroupBy(x => x.Customer)
            //             .Where(g => g.Sum(x => x.Price) >= 100 && g.Sum(x => x.Price) < 300)
            //             .Select(g => g.Key);

            return from order in orders
                   group order by order.Customer into gb
                   where gb.Sum(x => x.Price) >= 100 && gb.Sum(x => x.Price) <= 300
                   select gb.Key;
                   


        }

    }
}
