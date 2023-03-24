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
            //Solution(new string[] { "Ab", "bc","cd","efg", "xyZ" });
            var res = Solution(new string[] { "*====#", "X-+-+-+-+-+-Z","#______X","A.........*" });
            Console.WriteLine("Hello World!");
        }

        private static string Solution(string[] parts)
        {
            var strStart = parts.Where(x => x.StartsWith('A')).FirstOrDefault();
            var strEnd = parts.Where(x => x.EndsWith('Z')).FirstOrDefault();

            var strArray = parts.Where(x => !x.Equals(strStart) && !x.Equals(strEnd)).ToList();

            List<string> result = new List<string> { strStart};

            strArray.Add(strEnd);

            foreach (var str in strArray)
            {

                var end = result[^1][^1];
                var start = str[0];
                if (start == end)
                {
                    var c = str[1..];
                    result.Add(c);
                }
                else
                {
                    result.Add(str);
                }
            }
           

            return string.Join("", result); ;
       
        }
    }

   
}
