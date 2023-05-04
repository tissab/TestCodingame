using System;
using System.Linq;

namespace FindSmallestInterval
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = Solution.FindSmallestInterval(new int[] { 15,98, 22, 74, 44, 72});
            Console.WriteLine("Le resultat est :"+ res);
        }
    }

    class Solution
    {
        public static int FindSmallestInterval(int[] numbers)
        {
            var arr = numbers.OrderBy(x => x).ToArray();
            var max = int.MaxValue;
            int diffMin = 0;
            for(int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i+1] - arr[i] < max)
                {
                    max = arr[i + 1] - arr[i];
                    diffMin = max;
                }
            }
            return diffMin;
        }
    }
}
