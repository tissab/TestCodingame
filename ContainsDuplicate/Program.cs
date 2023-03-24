using System;
using System.Linq;

namespace ContainsDuplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var res = ContainsDuplicate(new int[] { 1, 2, 3, 1 });
            var res1 = ContainsDuplicate(new int[] { 1, 2, 3, 4 });
            var res2 = ContainsDuplicate(new int[] { 1, 1, 1, 3,3,4,3,2,4,2 });
            Console.WriteLine("Hello World!");
        }

        static bool ContainsDuplicate(int[] nums)
        {
            return (from num in nums
                    group num by num into GB
                    select GB.Count()).Where(x => x > 1).Any();
        }
    }
}
