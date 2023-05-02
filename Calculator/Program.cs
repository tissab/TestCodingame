using System;
using System.Globalization;
using System.Linq;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var res = Sum("-1.001", "1.01");
            Console.WriteLine("Hello World! "+res);

        }

        static string Sum(params string[] numbers)
        {
           return numbers.Select(x => double.Parse(x,CultureInfo.InvariantCulture)).Sum().ToString();

            //decimal total = 0;

            //foreach (string number in numbers)
            //{
            //    total += decimal.Parse(number);
            //}
            //return total.ToString();
        }
    }
}
