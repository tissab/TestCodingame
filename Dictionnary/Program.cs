using System;
using System.Collections.Generic;

namespace Dictionnary
{
    class Program
    {
        static void Main(string[] args)
        {
            //var m = new Dictionary<object, int>();
            //var o1 = new object();

            //var o2 = o1;
            //m[o1] = 1;
            //m[o2] = 2;

            var r1 = new Dictionary<string, int>
            {
                { "a", 21 },
                { "b", 20 },
            };

            var y = r1["a"];

            //var f = r1.TryGetValue("a", out t1);



            var r = new Dictionary<Personne, int>
            {
                { new Personne { Nom = "Bassit", Prenom = "Diby", Age = 34}, 21 },
                { new Personne { Nom = "Biekre", Prenom = "Elpi", Age = 33}, 20 },
                { new Personne { Nom = "Bassit", Prenom = "Diby", Age = 34}, 18 }
            };

            var f = r[new Personne { Nom = "Bassit", Prenom = "Diby", Age = 34 }];

            int t ;
            
            r.TryGetValue(new Personne { Nom = "Bassit", Prenom = "Diby", Age = 34 },out t);

            Console.WriteLine(t);

            //Quelle valeur retournee par m[01] :
            /*
                - null
                - 2*
                - 3
                - 1
             */

            // La valeur est 2 car les deux objets partagent la meme adresse memoire d'ou la modification de l'un se reflete sur l'autre

        }

        public class Personne
        {
            public string Nom { get; set; }
            public string Prenom { get; set; }
            public int Age { get; set; }
        }
    }
}
