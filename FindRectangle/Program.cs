using System;
using System.Collections.Generic;

namespace FindRectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Tuple<int, int>> coords1 = new List<Tuple<int, int>>()
            {
                Tuple.Create(0,0),
                Tuple.Create(1,0),
                Tuple.Create(1,1),
                Tuple.Create(0,1),
            };
            var res = FindRectangle(coords1);
            Console.WriteLine("Hello World!");
        }

        public static int FindRectangle(List<Tuple<int, int>> coords)
        {
            // Compteur de rectangles trouvés
            int count = 0;

            // Dictionnaire de coordonnées pour faciliter la recherche des diagonales
            Dictionary<Tuple<int, int>, bool> coordDict = new Dictionary<Tuple<int, int>, bool>();
            foreach (var coord in coords)
            {
                coordDict[coord] = true;
            }

            // Parcours de toutes les paires de coordonnées
            for (int i = 0; i < coords.Count; i++)
            {
                for (int j = i + 1; j < coords.Count; j++)
                {
                    Tuple<int, int> p1 = coords[i];
                    Tuple<int, int> p2 = coords[j];

                    // Vérification si p1 et p2 sont deux coins opposés d'un rectangle
                    if (p1.Item1 < p2.Item1 && p1.Item2 < p2.Item2
                        && coordDict.ContainsKey(new Tuple<int, int>(p1.Item1, p2.Item2))
                        && coordDict.ContainsKey(new Tuple<int, int>(p2.Item1, p1.Item2)))
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
