using System;

namespace Access_Concurrentiel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Counter
    {
        private static int count = 0;

        private static readonly object countLock = new object();
        public static int Increment()
        {
            lock (countLock)
            {
                count = count + 1;
                        return count;
            }
        }

    }
}
