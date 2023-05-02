using System;

namespace AsciiArt_
{
    class Program
    {
        static void Main(string[] args)
        {
            //string art = AsciiArt
            Answer.ScanChar("A");
            Console.WriteLine("Hello World!");
        }
    }

    class Answer
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
