using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodingame.Nombre_DePaires
{
    class Paires
    {
        public static int NombredePaires(int n)
        {
            if (n < 2 || n > 1000) return 0;
            if (n == 1) return 0;
            return ((n - 1) + NombredePaires(n - 1));
        }
    }
}
