using System;
using System.Linq;

namespace CountPrimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var res = CountPrimes(11);
            Console.WriteLine("Hello World!");
        }

        private static int CountPrimes(int n)
        {
            var res = Enumerable.Range(0, n).Where(x => Check_Prime(x) && x <= n).Count();
             
            bool Check_Prime(int number)
            {
                if (number < 2) return false;

                var tem = Math.Sqrt(number);
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if(number % i == 0) return false;
                }
                return true;
            }

            return res;
        }

         
    }
}
