using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;

namespace RebuildMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Solution(new string[] { "defgx","bc","xyZ","cd","Ab" });
            //"#______X", "A.........*", "*====#", "X-+-+-+-+-+-Z"
            Stopwatch sw = Stopwatch.StartNew();
            Stopwatch sw1 = Stopwatch.StartNew();

            sw1.Start();
            var res1 = Solution_1(new string[] { "defgx", "bc", "xyZ", "cd", "Ab" });
            sw1.Stop();

            sw.Start();
            var res = Solution(new string[] { "defgx", "bc", "xyZ", "cd", "Ab" });
            sw.Stop();

            Console.WriteLine($"First  {res1} {sw.Elapsed.TotalMilliseconds} and second {res} {sw1.Elapsed.TotalMilliseconds}");
        }

        private static string Solution(string[] parts)
        {
           StringBuilder sb = new StringBuilder();

            Queue<string> queue = new Queue<string>(parts);

            while (queue.Count > 0)
            {

                if (sb.Length == 0)
                {
                    sb.Append(queue.Dequeue());
                }
                else
                {
                    var start = sb[0];
                    var end   = sb[^1];

                    var item = queue.Dequeue();

                    if(start == item[^1] || end == item[0])
                    {
                        if(start == item[^1])
                        {
                            var res = item[0..^1];
                            sb.Insert(0, res);
                        }
                        else
                        {
                            var res = item[1..^0];
                            sb.Append(res);
                        }
                    }
                    else
                    {
                        queue.Enqueue(item);
                    }

                }
            }
            return string.Join("", sb); ;
        }

       
        private static string Solution_1(string[] args)
        {
            string message = args.Where(arg => arg[0] == 'A').FirstOrDefault();
            char lastCharacter = message[message.Length - 1];

            while (lastCharacter != 'z' && lastCharacter != 'Z')
            {
                char finalLastCharacter = lastCharacter;
                string nextString = args.Where(arg => arg[0] == finalLastCharacter).FirstOrDefault();
                lastCharacter = nextString[nextString.Length - 1];
                message = message + nextString.Substring(1);
            }

            return message;
        }






    }


}
