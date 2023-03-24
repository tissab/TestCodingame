using System;
using System.Collections.Generic;
using System.Linq;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var res = Filter(new[] { "bob", "bobi", "ici", "baba" });
            Console.WriteLine("Hello World!");
        }

        public static IEnumerable<string> Filter(IEnumerable<string> strings)
        {
            return strings.Where((s) => string.Join("",s.Reverse()).Equals(s)).ToList();
        }
    }
}
