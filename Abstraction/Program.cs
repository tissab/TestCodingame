using System;
using System.Collections.Generic;
using System.Linq;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



            Shape s = new Square();
            Shape c = s as Circle;

            var numbers = new int[] { 1, 2, 3, 4, 5, 6 };
            
            var isParsed = int.TryParse("1", out _);

            //var res1 = numbers[-4..-1];
            //var res2 = numbers[^0..^3];
            //var res3 = numbers[-3..0];
            //var res4 = numbers[3..0];
            var res5 = numbers[^4..^1];
            var res6 = numbers[^3..^0];

        }

    }

    class Shape { }
    class Square : Shape { }
    class Circle : Shape { }

   

    interface CapableDeVoler
    {
        void vole();
    }

    abstract class Avion : CapableDeVoler
    {
        public abstract void vole();
    }

    abstract class Oiseau : CapableDeVoler
    {
        public abstract void vole();
    }
}
