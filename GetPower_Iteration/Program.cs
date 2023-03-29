using System;
using System.Collections.Generic;

namespace GetPower_Iteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach(int power in GetPower(2))
            {
                Console.WriteLine(power);
                if(power> 20)
                {
                    break;
                }
            }
        }

        static IEnumerable<ulong>GetPower(uint value)
        {
            uint res = 1;
            while (true)
            {
                yield return res *= value;
            }
        }
    }
}
