using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace FirstOccurence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var re = FirstOccurence("ab*de", "abcdexy");
            Console.WriteLine("Hello World!");
        }

        public static int FirstOccurence(string x, string s)
        {
            // Construire la regex pour le motif
            string regexPattern = x.Replace("*", "."); // Remplacer le caractère générique par "."
            Regex regex = new Regex(regexPattern);

            // Chercher la première correspondance
            Match match = regex.Match(s);
            if (match.Success)
            {
                return match.Index;
            }
            else
            {
                return -1; // Aucune correspondance trouvée
            }
        }

    }
}
