using System;

namespace FindLargest
{
    class Program
    {
        static void Main(string[] args)
        {

            var res = FindLargest(new int[] { 100, 85, 41, 56, 089, 90 });
            Console.WriteLine($"Hello World! {res}");
        }

        public static int FindLargest(int[] numbers)
        {
            int result = numbers[0];

            foreach(int i in numbers)
            {
                if(result < i)
                {
                    result = i;
                }
            }

            return result;
        }
    }


}
