using System;
using System.Text.RegularExpressions;

namespace MyAtoi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var res = MyAtoi("-0004193 avec mots 90");
            Console.WriteLine("Hello World!");
        }

        static int MyAtoi(string s)
        {
            string pattern = @"([-+]?\d+)";
            Regex regex = new Regex(pattern);
            var value = int.Parse(regex.Match(s).Value);

           return value;
        }
            
    }
}
