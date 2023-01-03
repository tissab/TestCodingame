using System;

namespace ClosetToZero
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = A.ClosestZero(new int[] { 8, 2, 5, 3, -2 });
            Console.WriteLine($"Hello World! {res}");
        }

    }

    class A
    {
        public static int ClosestZero(int[] ints)
        {
            int res;

            if(ints.Length > 0)
            {
                if(ints != null)
                {
                    res = ints[0];

                    for(int j = 0; j < ints.Length; j++)
                    {
                        if(Math.Abs(res) > Math.Abs(ints[j]))
                        {
                            res = ints[j];
                        }
                        else if(Math.Abs(res) == Math.Abs(ints[j]))
                        {
                            if(res > 0 || ints[j] > 0)
                            {
                                res = Math.Abs(res);
                            }
                            
                        }
                    }
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }

            return res;
        }
    }
}
