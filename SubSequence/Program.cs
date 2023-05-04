using System;

namespace SubSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s1 = "abc";
            var s2 = "abcbabc";

            //var s1 = "rabbit";
            //var s2 = "rabbbit";
            var res = getSubsequenceCount(s1,s2);
            Console.WriteLine("Hello World!");
        }

        public static int getSubsequenceCount(string s1, string s2)
        {
            //var s1 = "abc";
            //var s2 = "abcbabc";
            int[,] dp = new int[4, s2.Length + 1];
            for (int j = 0; j <= s2.Length; j++)
            {
                dp[0, j] = 1;
            }
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= s2.Length; j++)
                {
                    var s1_ = s1[i - 1]; var s2_ = s2[j - 1];
                    if (s1[i - 1] != s2[j - 1])
                    {
                        var dp1 = dp[i, j - 1];
                        dp[i, j] = dp[i, j - 1];
                    }
                    else
                    {
                        var dp2 = dp[i - 1, j - 1] + dp[i, j - 1];
                        dp[i, j] = dp[i - 1, j - 1] + dp[i, j - 1];
                    }
                }
            }
            var dp3 = dp[3, s2.Length];
            return dp[3, s2.Length];
        }
    }
}
