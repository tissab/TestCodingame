using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodingame.Exo25
{
    class Exo_25
    {

        public static String Reshape(int n, String str)
        {
            String modifStr;
            if(str == null)
            {
                return str;
            }

            var strs = str.Trim().Split(null);
            var strBuilder = new StringBuilder(strs.Length);
            for(int i = 0; i< strs.Length; i++)
            {
                strBuilder.Append(strs[i]);
            }
            modifStr = strBuilder.ToString();

            int nbChar = modifStr.Length;

            if(nbChar <= n)
            {
                return modifStr;
            }

            int newStrLength = modifStr.Length;

            string whiteSpace = "\r";

            for(int i = n; i <= newStrLength; i += n)
            {
                modifStr = modifStr.Insert(i, whiteSpace);
                i++;
                newStrLength++;
            }
            
            return modifStr;
        }

        public static String Reshape1(int n, String str)
        {
            var res =  str.Substring(0, n) + str.Substring(str.Length - n, str.Length);

            return res;
        }
    }
}
