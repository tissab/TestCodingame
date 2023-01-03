using System;
using System.Collections;

namespace Approx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static double Approx(Point[] pts)
        {
            var pointsThatSatisfyTheFormula = new ArrayList();

            for (int i = 0; i < pts.Length; i++)
            {
                var point = pts[i];
                var x = point.x;
                var y = point.y;

                if (Math.Pow(x, 2) + Math.Pow(y, 2) <= 1)
                {
                    pointsThatSatisfyTheFormula.Add(point);
                }
            }

            var approximateValueOfPi = 4 * (pointsThatSatisfyTheFormula.Count / pts.Length);

            return approximateValueOfPi;
        }
    }

    class Point
    {
        public double x, y;
    }
}
