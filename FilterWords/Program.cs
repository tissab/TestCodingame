using System;
using System.Linq;

namespace FilterWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = FilterWords(new string[] { "the", "dog", "got", "a", "bone" }, "ae");
            Console.WriteLine("Hello World!");
        }

        static string[] FilterWords(string[] words, string letter)
        {
            return words.Where(x => x.IndexOfAny(letter.ToCharArray()) > -1).ToArray();
        }
    }
}
