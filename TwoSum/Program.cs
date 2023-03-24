using System;

namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var res = TwoSum(new int[] {2,7,11,15},9);
            var res1 = TwoSum(new int[] {3,2,4},6);
            var res2 = TwoSum(new int[] {3,3},6);
            Console.WriteLine("Hello World!");
        }
            
        static int[] TwoSum(int[] nums, int target)
        {
            int[] resultat = new int[2];
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = i+1; j< nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        resultat = new int[]{ i,j};
                        break;
                    }
                }
            }
            return resultat;
        }
    }
}
