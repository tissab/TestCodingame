using System;
using System.Linq;
using System.Text;

namespace Reshape
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = Reshape(4, "abc de fghij");
            Console.WriteLine($"{r}");
        }

        public static string Reshape(int n, string str)
        {

            var modifStr = str.Replace(" ", "");

            int newStrLength = modifStr.Length;

            for (int i = n; i <= newStrLength; i += n)
            {
                modifStr = modifStr.Insert(i, Environment.NewLine);
                i++;
                newStrLength++;
            }

            return modifStr.ToString();
        }

      
    }
}
