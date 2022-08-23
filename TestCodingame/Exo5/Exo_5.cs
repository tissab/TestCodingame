using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodingame.Exo5
{
    class Exo_5
    {

    }

    class Base
    {
        public virtual void Foo() { }
    }

    class Bar : Base
    {
        public sealed override void Foo()
        {
            base.Foo();
        }
    }

    class Derive : Bar
    {
       //public override void Foo()
       //{

       //}
    }
}
