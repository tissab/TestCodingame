using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodingame.Exo10
{
    static class Exo_10
    {

        public static int Total()
        {
            var list = new List<int>(2);

            list.Add(1);
            list.Add(1);
            list.Add(1);

            return list.Count();  // ==> 3
            /*
               - 5
               - 1
               - Ce code leve une exception
               - 3*
               - 2
             */
        }
    }
}
