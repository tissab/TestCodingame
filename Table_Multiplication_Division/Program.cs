using System;

namespace Table_Multiplication_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var resultatM = GetMultiplicationTable();
            var res = resultatM[2, 8];
            var resultatD = GetDivisionTable();
            var res1 = resultatD[2, 8];

            Console.WriteLine("Hello World!");
        }

        static string[,] GetMultiplicationTable()
        {
            string[,] tableMult = new string[11, 11];

            for(int i = 0; i< 11; i++)
            {
                for(int j = 0; j< 11; j++)
                {
                    var res = i * j;
                    tableMult[i, j] = $"{i}*{j}={res}";
                }
                
            }
            return tableMult;
        }

        static string[,] GetDivisionTable()
        {
            string[,] tableDivi = new string[10, 10];

            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    var res = (i*j) / i;
                    var response = $"{(i * j)}/{i}={res}";
                    tableDivi[i, j] = response;
                }

            }
            return tableDivi;
        }
    }
}
