using System;

namespace Dictionnary
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = new Dictionary<object, int>();
            var o1 = new object();

            var o2 = o1;
            m[o1] = 1;
            m[o2] = 2;

            //Quelle valeur retournee par m[01] :
            /*
                - null
                - 2*
                - 3
                - 1
             */

            // La valeur est 2 car les deux objets partagent la meme adresse memoire d'ou la modification de l'un se reflete sur l'autre

        }
    }
}
