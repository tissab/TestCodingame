using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodingame.Exo20
{
    class Exo_20
    {

        /*
         Partout ou un objet de type T est attendu, on doit pouvoir passer un objet de type U, avec U heritant de T. ==> VRAI
         */
        Genirique<Derive> genirique = null;
        public Exo_20()
        {
            genirique = new Genirique<Derive>();
        }
        
        public void Test()
        {
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
