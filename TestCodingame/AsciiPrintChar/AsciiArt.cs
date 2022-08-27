using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodingame.AsciiPrintChar
{
    class AsciiArt
    {
        static string PrintChar(char letter)
        {
            return letter.ToString();
        }

        static char ScanChar(string s)
        {
            //bool charFound = false;
            char lettre = '?';

            for(char i = 'A'; i <= 'Z'; i++)
            {
                if(s.CompareTo(PrintChar(i)) == 0)
                {
                    //charFound = true;
                    lettre = i;
                }
            }

            return lettre;
        }

      
    }
}
