using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace RebuildMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (int number1, int number2) numbers = (1, 3);
            Console.WriteLine("Hello World!");
        }

        private static string Solution(string[] parts)
        {
            var strStart = parts.Where(x => x.StartsWith('A')).FirstOrDefault();
            var strEnd = parts.Where(x => x.EndsWith('Z')).FirstOrDefault();

            var strWithoutStartandEnd = parts.Where(x => !x.StartsWith('A') || !x.EndsWith('Z')).ToList();

            var end1 = strStart.ToCharArray()[strStart.ToCharArray().Length - 1];
            var end2 = strEnd.ToCharArray()[strStart.ToCharArray().Length - 1];

            foreach(var str in strWithoutStartandEnd)
            {
                var c = str.ToCharArray()[str.ToCharArray().Length - 1];
            }
            return null;
       
        }
    }

    public class A : B
    {
        
        public void RR()
        {
            str = "qwww";
        }
       
    }


    public class B : C
    {
        public string str = "foo";
    }

    public class C
    {
        
    }
}
