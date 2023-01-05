using System;
using System.Linq;

namespace AnswerExists
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine($"It is exist {AnswerExist(new int[] { -9, 14, 37, 100 }, 100)}");
        }

        static bool AnswerExist(int[] ints, int k)
        {
            //return ints.Any(x => x == k);

            return Array.BinarySearch(ints, k) >= 0;
        }
    }
}
