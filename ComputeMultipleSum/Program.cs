// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

class Solution
{
    public static int ComputeMultipleSum(int n)
    {
        if (n < 0 || n > 1_000) throw new ArgumentException("");

        int sum = 0;

        for(int i = 1; i < n; i++)
        {
            if (i % 3 == 0 || i % 5 == 0 || i % 7 == 0) sum += i;
        }
        return sum;
    }

}
