using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace IsUgly
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stopwatch stopwatch2 = new Stopwatch();

            stopwatch2.Start();
            var res = GetIdealNums(200, 405);
            stopwatch2.Stop();

            Console.WriteLine($"Stop {res} "+ stopwatch2.ElapsedMilliseconds);
        }

        

        static bool IsUgly(int n)
        {
            if(n <= 0) return false;
            if(n == 1) return true;
            if (n % 2 == 0) return IsUgly(n / 2);
            if (n % 3 == 0) return IsUgly(n / 3);
            if (n % 5 == 0) return IsUgly(n / 5);
            return false;
        }

        public static int GetIdealNums(int low, int high)
        {
            int count = 0;
            int x = 0;
            while (Math.Pow(3, x) <= high) 
            {
                int y = 0;
                while (Math.Pow(3, x) * Math.Pow(5, y) <= high)
                {
                    int num = (int)(Math.Pow(3, x) * Math.Pow(5, y));
                    if (num >= low)
                    {
                        count++;
                    }
                    y++;
                }
                x++;
            }
            return count;
        }
    }
}
