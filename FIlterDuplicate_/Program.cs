using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace FIlterDuplicate_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static int[] FilterDuplicate(int[] data)
        {
            return data.Distinct().ToArray();
        }
       
    }


}
