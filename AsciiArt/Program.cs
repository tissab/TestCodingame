using System;

namespace AsciiArt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class AsciiArt
    {
        static string PrintChar(char letter)
        {
            return letter.ToString();
        }

        public static char ScanChar(string s)
        {
            //bool charFound = false;
            char lettre = '?';

            for (char i = 'A'; i <= 'Z'; i++)
            {
                if (s.CompareTo(PrintChar(i)) == 0)
                {
                    //charFound = true;
                    lettre = i;
                }
            }

            return lettre;
        }


    }
}
