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

        
    }
}
