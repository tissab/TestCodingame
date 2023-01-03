using System;

namespace NombrePaire
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int NombredePaires(int n)
        {
            if (n < 2 || n > 1000) return 0;
            if (n == 1) return 0;
            return ((n - 1) + NombredePaires(n - 1));
        }
    }
}
