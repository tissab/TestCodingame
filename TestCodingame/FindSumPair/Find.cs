using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodingame.FindSumPair
{
    class Find
    {
        public static int[] FindSumpair(int [] numbers, int k)
        {
            int[] pairs = new int[2];

            for(int i = 0; i < numbers.Length; i++)
            {
                for(int j = i+1; j < numbers.Length; j++)
                {
                    if(numbers[i] + numbers[j] == k)
                    {
                        pairs = new int[] { i, j };

                        if(numbers[i] + numbers[j] != k)
                        {
                            pairs = new int[] { 0, 0 };
                        }
                    }
                }
            }
            return pairs;
        }
    }
}
