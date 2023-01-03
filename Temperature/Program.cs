using System;
using System.Linq;

namespace Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Temp
    {
        public static double ClosesToZero(double[] ts)
        {
            if (ts.Length == 0) return 0;
            var closest = ts[0];
            foreach (double d in ts)
            {
                double abs = Math.Abs(d);
                double absClosest = Math.Abs(closest);
                if (abs < absClosest)
                {
                    closest = d;
                }
                else if (abs == absClosest && closest < 0)
                {
                    closest = d;
                }
            }

            return closest;
        }

        public static double ClosesToZero_1(double[] ts)
        {
            double result = 0;

            if (ts.Length > 0)
            {
                result = ts
                          .OrderBy(i => Math.Abs(i))
                          .GroupBy(i => Math.Abs(i))
                          .First()
                          .Max();

            }

            return result;
        }

        public static double ClosesToZero_2(double[] ts)
        {
            if (ts.Length == 0)
                return 0;
            return ts.OrderBy(t => Math.Abs(t)).ThenBy(t => -t).First();
        }
    }
}
