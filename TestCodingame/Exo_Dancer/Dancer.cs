using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodingame.Exo_Dancer
{
    class Dancer
    {
        public static int GetPositionAt(int n)
        {
            switch (n % 6)
            {
                case 0: return 0;
                case 1: return 1;
                case 2: return -1;
                case 3: return -4;
                case 4: return -5;
                case 5: return -3;
            }
            return 0;
        }
    }
}
