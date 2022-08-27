using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodingame.Exo21
{
    class Exo_21
    {

        public static string LocateUniverseFormula()
        {
            /// <summary>
            /// Rechercher un fichier dans tous les repertoires et les sous-repertoires, puis renvoi le
            /// premier element retrouvé
            /// </summary>
            /// <returns></returns>

            //var rep = @"C:\";
            var rep = @"tmp/documents";
            var fileName = "universe-formula";

            DirectoryInfo dr = new DirectoryInfo(rep);
            FileInfo[] allFiles = dr.GetFiles(fileName, SearchOption.AllDirectories);

            return allFiles.Select(p => p.FullName).FirstOrDefault();
            
        }
    }
}
