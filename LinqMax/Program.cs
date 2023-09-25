using System;
using System.Linq;

namespace LinqMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int CountMax()
        {
            return new[] { "pomme", "orange", "abricot", "kiwi" }.Max(c => c.Length);  // ==> 7
            /*
                  - abricot
                  - 7   *
                  - pomme
                  - Erreur de compilation
             */
        }
    }
}
