using System;
using System.Linq;

namespace CalculateTotalPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = Solution.CalculateTotalPrice(new int[] {5,5}, 0);
            Console.WriteLine($"Hello World! {res}");
        }
    }

    class Solution
    {
        public static int CalculateTotalPrice(int [] prices, int discount)
        {
            decimal x = 0;
            decimal res = 0;

            if ((discount < 0 || discount > 100) || ( prices.Length == 0 ||prices.Length > 100) )
            {
                return -1;
            }

            if(prices.Length > 1)
            {
                x = prices.Max();
                res =  Math.Floor(x * (100 - discount) / 100) + prices.Sum() - x;

                return (int)res;
            }

            return prices[0];
        }
    }
}
