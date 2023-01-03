using System;

namespace StringDefault
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = default;

            // La valeur de string par defaut est Null;

            if (s is null)
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
