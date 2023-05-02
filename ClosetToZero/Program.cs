using System;
using System.Collections.Generic;
using System.Linq;

namespace ClosetToZero
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = A.ClosestZero(new int[] { });
            Console.WriteLine($"Hello World! {res}");
        }

    }

    class A
    {
        //Fonction optimale kader
        public static int ClosestZero(int[] ints)
        {
            return ints.OrderBy(t => Math.Abs(t)).ThenByDescending(t => t).DefaultIfEmpty(-1).First();
         }
        
        //Ancienne methode
        public static int ClosestZero_(int[] ints)
        {
            return ints.OrderBy(t => Math.Abs(t)).ThenBy(t => -t).FirstOrDefault();
        }

        public static int ComputeClosestToZero(int[] ts)
        {
            if (ts.Count() == 0) return 0;

            List<int> tsPosi = ts.Where(x => x > 0).ToList();
            List<int> tsNega = ts.Where(x => x < 0).ToList();

            if (tsPosi.Count > 0 && tsNega.Count > 0) 
                return tsPosi.Min() <= Math.Abs(tsNega.Max()) ? tsPosi.Min() : tsNega.Max();
            else if (tsPosi.Count > 0) return tsPosi.Min();
            else return tsNega.Max();
        }
    }
}
