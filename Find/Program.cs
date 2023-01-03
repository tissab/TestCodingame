using System;
using System.Linq;

namespace Find
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int[] FindSumpair(int[] numbers, int k)
        {
            int[] pairs = new int[2];

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == k)
                    {
                        pairs = new int[] { i, j };

                        if (numbers[i] + numbers[j] != k)
                        {
                            pairs = new int[] { 0, 0 };
                        }
                    }
                }
            }
            return pairs;
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

        public static int FindSmallestIntervall(int[] numbers)
        {
            if (numbers.Length == 0) return -1;

            numbers = numbers.Select(x =>
            {
                if (x < 0)
                {
                    return -x;
                }
                return x;
            }).ToArray();

            numbers = numbers.OrderBy(x => x).Distinct().ToArray();

            var interval = Math.Abs(numbers[0] - numbers[1]);

            //int max = int.MaxValue;

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    for(int j = i+1; j<numbers.Length; j++)
            //    {
            //        var interval = Math.Abs(numbers[i] - numbers[j]);
            //        if (interval < max)
            //        {
            //            max = interval;
            //        }
            //    }
            //}


            return interval;
        }
    }
}
