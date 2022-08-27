using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodingame.Exo18
{
    class Exo_18
    {
        public static void Count()
        {
            var hashSet = new HashSet<int>();
            hashSet.Add(1);
            hashSet.Add(1);
            hashSet.Add(2);

            var r = hashSet.Count(); // ==> HashSet elimine les valeurs en double d'ou le resultat est 2

            Console.WriteLine("Resultat est : {0}", r);
        }
    }
}
