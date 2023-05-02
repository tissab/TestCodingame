using System;

namespace ConditionTrue
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static bool ConditionTrue(int i, int j)
        {
            return (i == 1 || j == 1 || i + j == 1);
        }
    }
}
