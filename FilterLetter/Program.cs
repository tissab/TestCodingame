using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FilterLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = Filter(new List<string>(){ "Lambda", "Aardvark", "Lexicon"});
            Console.WriteLine("Hello World!");
        }

        static IEnumerable<string> Filter(List<string> strings)
        {
            //return strings.Where(x => x.Substring(0, 1).Equals("L", StringComparison.InvariantCultureIgnoreCase))
            //    .OrderBy(x => x).ToList();

            return strings.Where(x => x.StartsWith("L", StringComparison.InvariantCultureIgnoreCase)).OrderBy(x => x);
        }
    }
}
