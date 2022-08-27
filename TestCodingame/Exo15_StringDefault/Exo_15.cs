using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodingame.Exo15
{
    class Exo_15
    {
        public static void DisplayString()
        {
            string s = default;

            // La valeur de string par defaut est Null;

            if(s is null)
            {
                Console.WriteLine("Resultat de s : {0}", s);

            }
            else
            {
                Console.WriteLine("Resultat de s : {0}", 0);
            }

        }
    }
}
