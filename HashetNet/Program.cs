using System;
using System.Collections.Generic;
using System.Linq;

namespace HashetNet
{
    class Program
    {
        static void Main(string[] args)
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
