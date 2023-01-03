using System;

namespace GCollection
{
    class Program
    {
        static void Main(string[] args)
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
}
