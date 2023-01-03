using System;

namespace GeneriaqueType
{
    class Program
    {
        static void Main(string[] args)
        {
            Genirique<Derive> genirique = new Genirique<Derive>();

            genirique.GetT();
        }
    }

    class Base
    {

    }

    class Derive : Base
    {

    }

    class Genirique<T> where T : Base, new()
    {
        public T GetT()
        {
            return new T();
        }
    }
}
