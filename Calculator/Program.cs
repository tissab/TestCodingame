using System;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var res = Sum("-1,001", "1,01");
            Console.WriteLine("Hello World! "+res);

        }

        static string Sum(params string[] numbers)
        {
            decimal total = 0;

            foreach (string number in numbers)
            {
                total += decimal.Parse(number);
            }
            return total.ToString();
        }
    }
}
