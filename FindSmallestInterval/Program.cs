using System;
using System.Linq;

namespace FindSmallestInterval
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = Solution.FindSmallestInterval(new int[] { 15, 98, 22, 74, 44, 72});
            Console.WriteLine("Le resultat est :"+ res);
        }
    }

    class Solution
    {
        public static int FindSmallestInterval(int[] numbers)
        {
            var arr = numbers.OrderBy(x => x).ToArray();
            var comp = int.MaxValue;
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i+1; j<arr.Length; j++)
                {
                    var a = arr[j];
                    var b = arr[i];
                    var res = (a - b);
                    if (res < comp)
                    {
                        comp = arr[j] - arr[i];
                    }
                }
            }

            return comp;
        }
    }
}
