using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodingame.Exo12
{
    class Exo_12
    {
        class A
        {
            string str;
        }

        class B : A
        {
            public B()
            {
                // str n'est pas visible dans la classe B compte tenu de son encapsulation qui est private;

            }
        }
    }
}
