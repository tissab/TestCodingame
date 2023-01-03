using System;

namespace Segregation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    #region Proposition 1
    interface CapableDeVoler
    {
        void vole();
    }

    abstract class Avion : CapableDeVoler
    {
        public abstract void vole();
    }

    abstract class Oiseau : CapableDeVoler
    {
        public abstract void vole();
    }
    #endregion

    #region Proposition 2
    abstract class Avion2
    {
        public abstract void vole();
    }

    abstract class Oiseau2 : Avion
    {

    }
    #endregion
}
