using System;
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
            var res = IsUgly(100000001);
            stopwatch2.Stop();


            Console.WriteLine("Stop 1 "+ stopwatch2.ElapsedMilliseconds);
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
    }
}
