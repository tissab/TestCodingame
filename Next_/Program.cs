// See https://aka.ms/new-console-template for more information


Console.WriteLine(Solution.Next(2));
Console.WriteLine(Solution.Next(901));
Console.WriteLine(Solution.Next(958));
Console.WriteLine(Solution.Next(3025));
Console.WriteLine(Solution.Next(654321));


class Solution
{
    public static int Next(int n)
    {
        if(n <= 0 || n>= int.MaxValue) throw new ArgumentOutOfRangeException();

        string nString  = n.ToString();

        for(int i = n + 1; i < int.MaxValue; i++)
        {
            bool hashUniq = true;
            string iString = i.ToString();
            foreach(char c in iString)
            {
                if(nString.Contains(c))
                {
                    hashUniq = false;
                    break;
                }
            }

            if (hashUniq) return i;
        }
        return -1;
    }
}