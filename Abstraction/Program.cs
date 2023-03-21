﻿using System;
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

            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            //var isParsed = int.TryParse("1", out _);

            //(Square, Circle) t1 = (new Square { Id = 1, name = "Man" }, new Circle { Id = 1, name = "Man" });
            //(Square, Circle) t2 = (new Square { Id = 1, name = "Man" }, new Circle { Id = 1, name = "Man" });

            //(int, int) i = (1, 2);
            //(int, int) i1 = (1, 2);

            //var r = (i == i1);

            //var res = (t1== t2);
            var lastItem = numbers[^1];
            var res = numbers[1..^1]; // => 2, 3, 4, 5, 6, 7
            var res1 = numbers[1..4]; // => 2, 3, 4
            var res2 = numbers[3..7]; // => 4, 5, 6, 7
            var res3 = numbers[^6..^1]; // => 3, 4, 5, 6, 7
            var res4 = numbers[0..3];  // => 1, 2, 3
            var res5 = numbers[^4..^1];  // => 5, 6, 7
            var res6 = numbers[^3..^0];  // => 6, 7, 8
            var res7 = numbers[^3..^1];  // => 6, 7

        }

    }

    class Shape { }
    class Square : Shape 
    { 
        public int Id { get; set; }
        public string name { get; set; }
    }
    class Circle : Shape 
    {
        public int Id { get; set; }
        public string name { get; set; }
    }

   

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
