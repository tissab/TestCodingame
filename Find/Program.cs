using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Find
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 5, 8, 1, 2, 13, 0, 10, 3, 2, 11 };
            var res = FindSumPair(numbers, 13);

            Console.WriteLine($"Le resultat est : {res}");
        }

        //-------------------------------------------------------//

        static int FindMinDiff(int[] arr, int n)
        {
            // Step 1: Sort the array
            Array.Sort(arr);

            // Step 2: Initialize minDiff with a large value
            int minDiff = int.MaxValue;

            // Step 3: Find the minimum difference
            for (int i = 0; i < n - 1; i++)
            {
                int diff = arr[i + 1] - arr[i];
                if (diff < minDiff)
                {
                    minDiff = diff;
                }
            }

            // Step 4: Return the minimum difference
            return minDiff;
        }

        static int[] FindSumPair(int[] arr, int n)
        {
            var pairs = new int[] { 0, 0 };
            List<int[]> ls = new List<int[]>();
            var x = arr.Length - 1;
            for (int i = 0; i < x; i++)
            {
                var temp = arr[i + 1] + arr[i];
                if (arr[i+1]+arr[i] == n)
                {
                    pairs = new int[] { i, i+1 };
                    ls.Add(pairs);
                }
            }
            var res = ls.OrderBy(x => x[0]).First();
            return res;
        }
    }
}
