using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodingame.Exo7
{
    class Exo_7
    {
        /*
         Des deux propostions c'est la proposition 1 que je prefere

        Nous avons une segregation d'interface qui est construite ou les methodes sont separees

        Et en dehors de la methode Vole qu' elles ont en commun chaque classe peut declarer sa propre methode.

        ce qui n'est pas le cas de la seconde proposition.
            
         */

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

    abstract class Oiseau2: Avion
    {

    }
    #endregion
}
