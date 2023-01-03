using System;
using System.Linq;

namespace MaxWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int MaxWeight(int[] weights, int w1, int w2)
        {

            var orderWeight1 = weights.OrderBy(x => x).Where(x => x <= w1).ToArray();
            var orderWeight2 = weights.OrderBy(x => x).Where(x => x <= w2).ToArray();

            if (orderWeight1.Length == 0 && orderWeight2.Length == 0)
            {
                return 0;
            }

            //var listw1 = weights.Where(x => x < w1).ToArray();
            var listw2 = weights.Where(x => x < w2).OrderByDescending(x => x).ToArray();

            //CalcW(w1, listw1, listw1.Length);
            CalcW(w2, listw2, listw2.Length);

            return -1;
        }
        private static void CalcW(int value, int[] arr, int nbr)
        {
            if (nbr > 0)
            {
                int calc = 0;
                nbr = nbr - 1;
                for (int i = 0; i <= nbr; i++)
                {
                    calc += arr[i];
                    if (calc <= value)
                    {
                        an.Add(calc);
                        if (calc == value)
                        {
                            break;
                        }
                    }
                    else
                    {
                        calc -= arr[i];
                    }

                    if (i == nbr)
                    {
                        arr = arr.Where((x, i) => i != 0).ToArray();
                        CalcW(value, arr, arr.Length);
                    }

                }
            }
        }
    }
}
