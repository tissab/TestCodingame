using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodingame.FindSmallInterval
{
    class FindSmall
    {
        public static int FindSmallestIntervall(int[] numbers)
        {
            if (numbers.Length == 0) return -1;

            numbers = numbers.Select(x =>
            {
                if(x < 0)
                {
                    return -x;
                }
                return x;
            }).ToArray();

            numbers = numbers.OrderBy(x => x).Distinct().ToArray();

            var interval = Math.Abs(numbers[0] - numbers[1]);

            //int max = int.MaxValue;

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    for(int j = i+1; j<numbers.Length; j++)
            //    {
            //        var interval = Math.Abs(numbers[i] - numbers[j]);
            //        if (interval < max)
            //        {
            //            max = interval;
            //        }
            //    }
            //}


            return interval;
        }
    }
}
