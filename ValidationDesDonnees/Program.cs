using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ValidationDesDonnees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var res1 = GetNumberOfChars(new string[2] { "a", "aa" });
            var res2 = GetSortedStrings(new string[2] { "b", "a" });
            var res3 = GetStringsStartingWith(new string[2] { "a", "b" },"b");
            var res4 = GetReverse(new string[2] { "a", "b" });
            var res5 = GetFormatedString(new string[2] { "a", "b" },"&{0}");

            Console.WriteLine("Hello World!");
        }

        static int GetNumberOfChars(IEnumerable<string> strings)
        {
            return strings.SelectMany(x => x).Count();
        }

        static IEnumerable<string> GetSortedStrings(IEnumerable<string> strings)
        {
            return strings.OrderBy(x => x);
        }

        static IEnumerable<string> GetStringsStartingWith(IEnumerable<string> strings, string startWith)
        {
            return strings.Where(x => x.StartsWith(startWith));
        }

        public static IEnumerable<string> GetReverse(IEnumerable<string> strings)
        {
            return strings.Reverse();
        }

        public static string GetFormatedString(IEnumerable<string> strings, string pattern)
        {
            var res =  strings.Select(x => string.Format(pattern, x)).ToArray();

            return string.Concat(res);
        }
    }
}
