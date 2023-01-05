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
    }
}