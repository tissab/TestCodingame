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
        
        private static string locateSubDir(string baseDir) {
            
		    string result = null;
		    string[] files = Directory.GetFileSystemEntries(baseDir);
		    
            foreach (string file in files) {
                
			    if (Directory.Exists(file)) {
				    result = locateSubDir(file);
				    if(result != null ) return result;

                } else {
				    FileInfo fileInfo = new FileInfo(file);
				    if(fileInfo.Name == "universe-formula") return file;
                }
		    }
		    return null;
	    }
	
	    public static string LocateUniverseFormula()
	    {
		    return locateSubDir("/tmp/documents");
	    }
    }
}
