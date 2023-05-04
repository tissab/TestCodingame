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
                { 1, 1, 0, 0, 0 },
            };

            int[,] matrix_1 = new int[,]
          {
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0 },
          };

            int[,] matrix1 = new int[,]
           {
                { 1, 1, 0, 1, 0 },
                { 1, 1, 1, 1, 1 },
                { 0, 1, 1, 1, 1 },
                { 0, 1, 1, 1, 1 },
                { 1, 1, 1, 1, 1 }
           };

            var res = FindLargestSquare(matrix_1);

            Console.WriteLine("Hello World!");
        }

           
        public static int FindLargestSquare(int[,] matrix)
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
