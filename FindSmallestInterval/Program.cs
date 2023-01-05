using System;
using System.Linq;

namespace FindSmallestInterval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Solution
    {
        public static int FindSmallestInterval(int[] numbers)
        {
            var arr = numbers.OrderBy(x => x).ToArray();

            var res = arr[1] - arr[0];

            return res;
        }
    }
}
