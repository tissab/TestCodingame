using System;
using System.Collections;
using System.Linq;




var rands = new Point[100000];
Random random = new Random();
for (int i = 0; i < rands.Length; i++)
{
    Point p = new Point();
    p.x = random.NextDouble();
    p.y = random.NextDouble();
    rands[i] = p;
}

Console.WriteLine(Pi.Approx(rands));

class Pi
{
       
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

        return 4 * (double)pointsThatSatisfyTheFormula.Count / pts.Count();

    }

    public static double Approx_(Point[] pts)
    {
        double nbreSucces = pts.Count(itemP => Math.Pow(itemP.x, 2) + Math.Pow(itemP.y, 2) <= 1);

        return 4 * (double)(nbreSucces / pts.Count());
    }
    
    
    //dernier version ajouter par KIPRE
    public static double Approx_(Point[] pts)
    {
     int into = 0;
        for (int i = 0; i < pts.Length; i++) {
            Point p = pts[i];
            if (p.x*p.x + p.y*p.y <= 1) into++;
        }
        // pi / 4 = into / n
        return (double)into / (double)(pts.Length) * 4d;  
     }
}

class Point
{
    public double x, y;
}

