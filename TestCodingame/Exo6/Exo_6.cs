﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodingame.Exo6
{
    class Exo_6
    {
        // ArrayList herite de IList donc c'est la methode qui retourne IList qui sera la plus privilegiee

        public ArrayList GetOrders()
        {
            return new ArrayList();
        }

        public IList GetOrder5s()
        {
            return new ArrayList();
        }
    }
}
