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
            //var sd = new SortedDictionary<int, int>(); sd[3] = 3; sd[2] = 1; sd[1] = 2;

            //foreach (var item in sd)
            //{
            //    Console.WriteLine(item.Value);
            //}

            var res = FrequencySort_v1(new int[] { -1, 1, -6, 4, 5, -6, 1, 4, 1 });
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

        static int[] FrequencySort_v1(int[] arr)
        {
            if (arr == null || arr.Length <= 1)
            {
                return arr;
            }

            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

            // Comptez la fréquence de chaque élément dans le tableau
            foreach (int num in arr)
            {
                if (frequencyMap.ContainsKey(num))
                {
                    frequencyMap[num]++;
                }
                else
                {
                    frequencyMap[num] = 1;
                }
            }

            // Triez le tableau en fonction de la fréquence (en ordre décroissant)
            var sortedArr = arr.OrderBy(num => frequencyMap[num]).ThenByDescending(num => num).ToArray();

            return sortedArr;
        }
    }
}
