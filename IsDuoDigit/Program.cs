using System;
using System.Linq;

namespace IsDuoDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var res = IsDuoDigit(12);
            var res1 = IsDuoDigit(110);
            var res2 = IsDuoDigit(-33333);
            var res3 = IsDuoDigit(102);

            Console.WriteLine("Hello World!");
        }
        static bool IsDuoDigit(int n)
        {
            var arrayNum = n.ToString().Replace("-","").ToCharArray();

            return (from nb in arrayNum
                    group nb by nb into GB
                    select GB.Count()).Count() <= 2;
        }
    }
}
