using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace MaxWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = MaxWeight(new int[] { 3, 2, 2, 2 }, 17, 5);
            Console.WriteLine($"Total : {res}");
        }

        public static int MaxWeight(int[] weights, int w1, int w2)
        {
            int c1 = 0;
            int c2 = 0;

            List<Tuple<List<int>, int>> arrayW1 = new List<Tuple<List<int>, int>>();

            List<Tuple<List<int>, int>> arrayW2 = new List<Tuple<List<int>, int>>();

            List<int> x1 = new List<int>();

            int resultat = 0;

            List<int> list = null;

            for (int i = 0; i < weights.Length; i++)
            {

                resultat = weights[i];
                if (resultat <= w1)
                {
                    list = new List<int>() { i};
                    arrayW1.Add(new Tuple<List<int>, int>(list, resultat));
                }

                list = new List<int>() {i};
                for (int j = i+1; j < weights.Length; j++)
                {
                    resultat +=  weights[j];
                    if (resultat <= w1)
                    {
                        list.Add(j);
                        arrayW1.Add(new Tuple<List<int>, int>(list, resultat));
                    }
                    else
                    {
                        resultat -= weights[j];
                    }
                }
            }

            if (arrayW1.Count == 0)
            {
                c1 = 0;
            }
            else
            {
                c1 = arrayW1.Select(x => x.Item2).Max();
                x1 = arrayW1.Where(x => x.Item2.Equals(c1)).FirstOrDefault().Item1;
            }

            List<int> list1 = null;
            int resultat1 = 0;

            for (int i = 0; i < weights.Length; i++)
            {
                if (!x1.Any(x => x.Equals(i)))
                {
                    resultat1 = weights[i];
                    if (resultat1 <= w2)
                    {
                        list1 = new List<int>() { i};
                        arrayW2.Add(new Tuple<List<int>, int>(list1, resultat1));
                    }

                    list1 = new List<int>() { i };
                    for (int j = i + 1; j < weights.Length; j++)
                    {
                       if (!x1.Any(x => x.Equals(j)))
                       {
                            resultat1 += weights[j];
                            if (resultat1 <= w2)
                            {
                                list1.Add(j);
                                arrayW2.Add(new Tuple<List<int>, int>(list1, resultat1));
                            }
                            else
                            {
                                resultat1 -= weights[j];
                            }
                       }
                    }
                }
            }

            if (arrayW2.Count == 0)
            {
                c2 = 0;
            }
            else
            {
                c2 = arrayW2.Select(x => x.Item2).Max();
                x1 = arrayW2.Where(x => x.Item2.Equals(c2)).FirstOrDefault().Item1;

            }

            var res = c1 + c2;

            return res;
        }
    }
}
