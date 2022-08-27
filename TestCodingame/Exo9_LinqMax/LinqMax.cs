using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodingame.Exo9
{
    public static class LinqMax
    {
        public static int  CountMax()
        {
           return  new[] { "pomme", "orange", "abricot", "kiwi" }.Max(c => c.Length);  // ==> 7
            /*
                  - abricot
                  - 7   *
                  - pomme
                  - Erreur de compilation
             */
        }
    }
}
