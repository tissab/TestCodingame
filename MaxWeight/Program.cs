using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = MaxWeight(new int[] { 10, 8, 3, 8 }, 5, 17);
            Console.WriteLine($"Total : {res}");
        }

        public static int MaxWeight(int[] weights, int w1, int w2)
        {
            List<int> arrayW1 = new List<int>();

            List<int> arrayW2 = new List<int>();

            for(int i = 0; i < weights.Length; i++)
            {
                if (weights[i] <= w1)
                {
                    arrayW1.Add(weights[i]);
                }

                if (weights[i] <= w2)
                {
                    arrayW2.Add(weights[i]);
                }

                for (int j = i+1; j < weights.Length; j++)
                {
                    if(weights[i] <= w1)
                    {
                        if (weights[i] + weights[j] <= w1)
                        {
                            arrayW1.Add(weights[i] + weights[j]);
                        }
                    }

                    if (weights[i] <= w2)
                    {
                        if(weights[i] + weights[j] <= w2)
                        {
                            arrayW2.Add(weights[i] + weights[j]);
                        }
                    }
                }
            }

            var res = arrayW1.Max() + arrayW2.Max();

            return res;
        }
    }
}
