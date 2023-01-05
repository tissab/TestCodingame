using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace TestCodingame
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 - Quelle propriété permet d'obtenir le nombre de caractère ==> Length;

            // 2 - Les interfaces peuvent contenir des methodes implementees? ==> Faux;

            // 3 - Exo 

            #region Ex0 3
            int i1 = 5;
            int i2 = 2;
            int i3 = i1 / i2;   // ==> 2
            #endregion

            //var r = Exo_9.CountMax();

            //var r1 = Exo_10.Total();

            //Console.WriteLine("Resultat : {0}", r1);

            //var r2 = Exo_11.Test(1, 5);
            //var r3 = Exo_11.Test(2, 3);
            //var r4 = Exo_11.Test(-3, 4);

            //Console.WriteLine("Resultat : {0} - {1} - {2}", r2, r3, r4);

            //Exo_15.DisplayString();

            //Exo_17.TestStruct();

            //Exo_18.Count();

            //Exo_22.Test();

            //var r2 = Exo_25.Reshape(3, "abc de fghij");
            // var r3 = Exo_25.Reshape(2, "1 23 456");

            Console.WriteLine("abc\rde\rfghij");

            //Console.WriteLine("Le resultat est : {0}", 01 | 11); //=> 11;
            //Console.WriteLine("Le resultat est : {0}", 00 | 11); //=> 11;
            //Console.WriteLine("Le resultat est : {0}", 10 & 11); //=> 10;
            //Console.WriteLine("Le resultat est : {0}", 1<<0); //=> 1
            //Console.WriteLine("Le resultat est : {0}",  0<<1); //=> 0


            // 4 - Exo
            #region Exo 4

            /* public interface A : B, C, D {} */
            /* Cette interface est correcte si B,C,D sont egalement des interfaces */

            #endregion

            // 8 - Exo
            #region Exo 8
            /*
              Vous avez une bibliotheque en C#. Parmi ces operations, laquelle privilegiez-vous pour traiter
              un comportement inattendu ?

                  - return false
                  - System.Environnement.Exit(-1)
                  - Console.WriteLine("Erreur : Comportement inattendu")
                  - throw new ComportementInattenduException()

              */
            #endregion          

        }


    }

   
}
