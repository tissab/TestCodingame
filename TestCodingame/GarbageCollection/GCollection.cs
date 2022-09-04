using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodingame.GarbageCollection
{
    class GCollection
    {
        // Quelle methode est utilisee pour executer une Garbage Collection et liberer la memoire du managed heap ?
        /*
            - GC.Collect() * : Force le ramassage des ordures.
            - GC.RemoveMemoryPressure(byte) : informe le runtime que la memoire non managee a ete liberee et n'a plus besoin d'etre pris en compte
                                              lors de planification
            - GC.Finalize() : Pour le nettoyage de la memoire
          
         */
    }
}
