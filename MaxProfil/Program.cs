using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxProfil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // [-1,9,0,8,-5,6,-24] => [1,5]
            int[] arr = { -1, 9, 0, 8, -5, 6, -24 }; 
            var res = MaxProfil(arr);
            Console.WriteLine($"Hello World! [{res}");
        }

        static int [] MaxProfil(int[] data)
        {
            List<(int, int[])> rapport = new List<(int, int[])>();

            for(int i = 0; i < data.Length; i++)
            {
                int calc = data[i];

                for(int j = i+1 ; j < data.Length; j++)
                {
                    calc += data[j];
                    rapport.Add((calc,new int[2] {i,j}));
                }      
            }

            var res = rapport.OrderByDescending(x => x.Item1).FirstOrDefault().Item2;

            return res;
        }
    }
}
