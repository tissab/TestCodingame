using System;

namespace GetIdealNums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int GetIdealNums(int low, int high)
        {
            int count = 0;
            int x = 0;
            while (Math.Pow(3, x) <= high)
            {
                int y = 0;
                while (Math.Pow(3, x) * Math.Pow(5, y) <= high)
                {
                    int num = (int)(Math.Pow(3, x) * Math.Pow(5, y));
                    if (num >= low)
                    {
                        count++;
                    }
                    y++;
                }
                x++;
            }
            return count;
        }
    }
}
