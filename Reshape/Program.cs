using System;
using System.Linq;
using System.Text;

namespace Reshape
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string Reshape(int n, string str)
        {

            //if(str == null)
            //{
            //    return str;
            //}

            //var strs = str.Trim().Split(null);
            //var strBuilder = new StringBuilder(strs.Length);
            //for(int i = 0; i< strs.Length; i++)
            //{
            //    strBuilder.Append(strs[i]);
            //}
            //modifStr = strBuilder.ToString();

            //int nbChar = modifStr.Length;

            //if(nbChar <= n)
            //{
            //    return modifStr;
            //}

            var modifStr = str.Replace(" ", "");

            int newStrLength = modifStr.Length;

            string whiteSpace = "\r";

            var strBuilder = new StringBuilder(modifStr.Length);

            for (int i = n; i <= newStrLength; i += n)
            {
                modifStr = modifStr.Insert(i, whiteSpace);
                i++;
                newStrLength++;
            }

            return modifStr.ToString();
        }

        public static string Reshape1(int n, string str)
        {
            var res = str.Substring(0, n) + str.Substring(str.Length - n, str.Length);

            return res;
        }

        public static string Reshape_2(int n, string str)
        {
            var a = str.Trim().Split(null);
            var strBuilder = new StringBuilder(str.Length);
            string modiStr;
            for (int i = 0; i < a.Length; i++)
            {
                strBuilder.Append(a[i]);
            }

            modiStr = strBuilder.ToString();

            var r = Enumerable.Range(0, modiStr.Length / n)
                              .Select(i => modiStr.Substring(i * n, n));

            var res = string.Join("\r", r);

            return res;
        }
    }
}
