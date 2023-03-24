using System;

namespace GetPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var res = GetPower(3, 3);
            Console.WriteLine("Hello World!");
        }

        static int GetPower(int number, int power)
        {
            if(power== 0)
            {
                return 1;
            }
            return number * GetPower(number, power - 1);

        }
    }
}
