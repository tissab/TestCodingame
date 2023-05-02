using System;
using System.Linq;

namespace ComputeJoinPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = ComputeJoinPoint(11, 7);
            Console.WriteLine($"Hello World! {res}");
        }

        static int ComputeJoinPoint(int s1, int s2)
        {
            int nombre_1 = s1;
            int nombre_2 = s2;

            if (0 >= s1 || s1 >= 20000000 || 0 >= s2 || s2 >= 20000000)
            {
                return 0;
            }

            if (nombre_1 == nombre_2)
            {
                return nombre_1;
            }

            try
            {
                while (nombre_1 != nombre_2)
                {
                    if (nombre_1 > nombre_2)
                    {
                        nombre_2 += nombre_2.ToString().Sum(a => int.Parse(new string(new char[] {a})));
                    }
                    else
                    {
                        nombre_1 += nombre_1.ToString().Sum(a => int.Parse(new string(new char[] {a})));
                    }
                }

                return nombre_1;
            }
            catch (FormatException ex)
            {
                return 0;
            }
        }
    }
}
