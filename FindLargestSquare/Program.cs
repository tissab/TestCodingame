using System;
using System.Collections.Generic;
using System.Linq;

namespace FindLargestSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,]
            {
                { 1, 1, 0, 1, 0 },
                { 1, 1, 1, 1, 1 },
                { 0, 0, 1, 1, 1 },
                { 0, 0, 1, 1, 1 },
                { 1, 1, 0, 0, 0 }
            };

            int[,] matrix1 = new int[,]
           {
                { 1, 1, 0, 1, 0 },
                { 1, 1, 1, 1, 1 },
                { 0, 1, 1, 1, 1 },
                { 0, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1 }
           };


            var res = FindLargestSquare_1(matrix);

            Console.WriteLine("Hello World!");
        }

        public static int FindLargestSquare(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            int[,] dp = new int[n, m];
            int maxSize = 0;

            // Initialisation de la première ligne et la première colonne de la matrice dp
            for (int i = 0; i < n; i++)
            {
                dp[i, 0] = matrix[i, 0];
                maxSize = Math.Max(maxSize, dp[i, 0]);
            }

            for (int j = 0; j < m; j++)
            {
                dp[0, j] = matrix[0, j];
                maxSize = Math.Max(maxSize, dp[0, j]);
            }

            // Remplissage de la matrice dp et mise à jour de maxSize
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < m; j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        dp[i, j] = Math.Min(dp[i - 1, j - 1], Math.Min(dp[i - 1, j], dp[i, j - 1])) + 1;
                        maxSize = Math.Max(maxSize, dp[i, j]);
                    }
                }
            }

            return maxSize ; // On retourne la surface de la plus grande sous-matrice carrée
        }

        public static int FindLargestSquare_1(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int m = matrix.GetLength(1);

            int[] dp = new int[m];
            int maxSize = 0;
            int prev = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int temp = dp[j];
                    int x = matrix[i, j];
                    if (i == 0 || j == 0 || x == 0)
                    {
                        dp[j] = matrix[i, j];
                    }
                    else
                    {
                        dp[j] = Math.Min(prev, Math.Min(dp[j], dp[j - 1])) + 1;
                    }
                    maxSize = Math.Max(maxSize, dp[j]);
                    prev = temp;
                }
            }

            return maxSize;
        }



    }
}
