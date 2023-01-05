using System;
using System.Collections.Generic;
using System.Linq;

namespace Find
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 5, 8, 1, 2, 13, 0, 10, 3, 2, 11 };
            var res = FindSumpair(numbers, 13);
            Console.WriteLine($"Le resultat est : {res}");
        }

        public static int[] FindSumpair(int[] numbers, int k)
        {
            var pairs = new int[] { 0, 0 };

            List<int[]> ls = new List<int[]>();

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == k)
                    {
                        pairs = new int[] { i, j };
                        ls.Add(pairs);
                    }
                }
            }

            var res = ls.OrderBy(x => x[0]).First();

            return res;
        }

        public static int FindMinDiff(int[] arr, int n)
        {
            int diff = int.MaxValue;

            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                    if (Math.Abs((arr[i] - arr[j])) < diff)
                        diff = Math.Abs((arr[i] - arr[j]));
            return diff;
        }

    }
}
