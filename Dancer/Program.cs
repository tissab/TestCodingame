using System;

namespace Dancer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Dancer
    {
        public static int GetPositionAt(int n)
        {
            switch (n % 6)
            {
                case 0: return 0;
                case 1: return 1;
                case 2: return -1;
                case 3: return -4;
                case 4: return -5;
                case 5: return -3;
            }
            return 0;
        }
    }
}
