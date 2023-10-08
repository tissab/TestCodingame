using System;
using System.Linq;

namespace Anagramme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var res = IsAnagram("anagram", "nagaram");
            var res1 = IsAnagram("presque", "peseur");
            var res2 = IsAnagram("Anagram", "nagaram");
            Console.WriteLine("Hello World!");
        }

        static bool IsAnagram(string s, string t)
        {
            if(s.Length != t.Length) return false; 
            return s.ToCharArray().OrderBy(x => x).SequenceEqual(t.ToCharArray().OrderBy(x =>x));
        }    

    
    }
}
