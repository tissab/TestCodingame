using System;

namespace CalcArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class CalcArray
    {
        public static int Calc(int[] array, int n1, int n2)
        {
            int total = 0;
            int index = 0;

            foreach (int element in array)
            {
                if (index >= n1 && index <= n2)
                {
                    total += element;
                    index++;
                }
            }

            return total;
        }
    }
}
