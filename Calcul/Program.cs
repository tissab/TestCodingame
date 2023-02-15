using System;
using System.Globalization;
using System.Linq;

namespace Calcul
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Calcul
    {
        public static string Sum(params string[] numbers)
        {
            var arr = numbers.Select(x => double.Parse(x, CultureInfo.InvariantCulture)).Sum();

            //double total = 0;

            //foreach(var number in arr)
            //{
            //    total = total + number;
            //}

            return arr.ToString();
        }

        public static void  fact(int value)
        {
            int t = value;
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = value;
                long a = (n - 1) / 3;
                long b = (n - 1) / 15;
                long c = ((n - 1) / 5);
                Console.WriteLine(3 * (((a + 1) * a) / 2) + 5 * (((c + 1) * c) / 2) - 15 * (((b + 1) * b) / 2));
            }
    }


}