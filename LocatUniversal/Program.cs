using System;
using System.IO;
using System.Linq;

namespace LocatUniversal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string LocateUniverseFormula()
        {
            /// <summary>
            /// Rechercher un fichier dans tous les repertoires et les sous-repertoires, puis renvoi le
            /// premier element retrouvé
            /// </summary>
            /// <returns></returns>

            //var rep = @"C:\";
            var fileName = "kadher";
            var filepath = @"tmp\documents";

            DriveInfo[] allDrives = DriveInfo.GetDrives();
            var rootPath = allDrives is null ? @"C:\" : allDrives[0].Name;

            var dirsInit = string.Concat(rootPath, filepath);

            if (!Directory.Exists(dirsInit)) return null;

            DirectoryInfo dr = new DirectoryInfo(dirsInit);

            FileInfo[] allFiles = dr.GetFiles($"{fileName}.*", SearchOption.AllDirectories);

            return allFiles.Select(p => p.FullName).FirstOrDefault();

            //var rep = @"tmp/documents";
            //var fileName = "universe-formula";

            //DirectoryInfo dr = new DirectoryInfo(rep);
            //FileInfo[] allFiles = dr.GetFiles(fileName, SearchOption.AllDirectories);

            //return allFiles.Select(p => p.FullName).FirstOrDefault();

        }
    }
}
