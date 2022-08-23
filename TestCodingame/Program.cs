using System;
using System.Collections;
using TestCodingame.Exo10;
using TestCodingame.Exo11;
using TestCodingame.Exo14;
using TestCodingame.Exo15;
using TestCodingame.Exo17;
using TestCodingame.Exo18;
using TestCodingame.Exo22;
using TestCodingame.Exo25;
using TestCodingame.Exo9;

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

            var r2 = Exo_25.Reshape1(3, "abc de fghij");
           // var r3 = Exo_25.Reshape(2, "1 23 456");

            Console.WriteLine(r2);

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

            #region Exo 13
            /*
             En base 2 (binaire) combien font 01 | 11 ==> ( 100 avec un peu de doute)
             */
            #endregion

        }

     
    }

   
}
