using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;

namespace FrequencySort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var res = FrequencySort(new int[] { -1, 1, -6, 4, 5, -6, 1, 4, 1 });
            Console.WriteLine("Hello World!");
        }

        static int[] FrequencySort(int[] nums)
        {

            var r = (from n in nums.OrderBy(n => n)
                    group n by n into gb
                    select new
                    {
                        id = gb.Key,
                        nbr = gb.Count()
                    }).OrderBy(x => x.nbr).ThenByDescending(x => x.id).ToArray();

            List<int> order = new List<int>();

            for(int i = 0; i < r.Length; i++)
            {
                order.AddRange(Enumerable.Repeat(r[i].id, r[i].nbr));
            }

            return order.ToArray();
        }
    }
}
