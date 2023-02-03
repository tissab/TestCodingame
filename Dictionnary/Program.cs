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

            var r = new Dictionary<Personne, int>
            {
                { new Personne { Nom = "Bassit", Prenom = "Diby", Age = 34}, 21 },
                { new Personne { Nom = "Biekre", Prenom = "Elpi", Age = 33}, 20 },
                { new Personne { Nom = "Bassit", Prenom = "Diby", Age = 34}, 18 }
            };

            int t = 12;
            
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
