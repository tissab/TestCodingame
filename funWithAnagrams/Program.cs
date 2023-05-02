using System;
using System.Collections.Generic;
using System.Linq;

namespace funWithAnagrams
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var param_1 = new List<string>
            {
                "code",
                "doce",
                "ecod",
                "framer",
                "frame"
            };

            var param_2 = new List<string>
            {
                "code",
                "aaagmnrs",
                "anagrams",
                "doce"
            };

            var res = funWithAnagram(param_2);
            Console.WriteLine("Hello World!");
        }

        public static List<string> funWithAnagram(List<string> text)
        {
            for(int i = 0; i <= text.Count; i++)
            {
                for(int j = i + 1; j<= text.Count-1; j++)
                {
                    if (text[i].Length == text[j].Length)
                    {
                        if (text[i].OrderBy(x => x).SequenceEqual(text[j].OrderBy(x => x)))
                        {
                            text.RemoveAt(j);
                            j = j -1;
                        }
                    }
                }
            }
            return text;
        }

    }
}
