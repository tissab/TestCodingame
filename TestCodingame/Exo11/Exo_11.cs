using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodingame.Exo11
{
    class Exo_11
    {
        public static bool Test(int i, int j)
        {
            if (i == 1 || j == 1 || i + j == 1)
                return true;
            return false;
        }
    }
}
