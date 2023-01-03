using System;

namespace StructureType
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
          Ce programme affiche :
                - 0
                - 5 *  => Les variables de type struct ou simple n'ont pas de reference ou d'adresse memoire il copie la valeur et non l'adresse
                - 10
                - null
          */
        }
        struct Struct
        {
            public int foo;
        }

        public static void TestStruct()
        {
            Struct struct1;
            struct1.foo = 5;

            Struct struct2 = struct1;
            struct2.foo = 10;

            Console.WriteLine("Resultat est : {0}", struct1.foo);
        }
    }

}
