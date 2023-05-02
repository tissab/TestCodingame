using System;
using System.Linq;

namespace CountPrimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var res = CountPrimes(9);
            Console.WriteLine("Hello World!");
        }

        private static int CountPrimes(int n)
        {
            var res = Enumerable.Range(0, n).Where(x => Check_Prime(x) && x < n).Count();

            bool Check_Prime(int number)
            {
                int i;
                for (i = 2; i <= number - 1; i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
                if (i == number)
                {
                    return true;
                }
                return false;
            }

            return res;
        }

         
    }
}
