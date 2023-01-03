using System;

namespace SealedClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
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
