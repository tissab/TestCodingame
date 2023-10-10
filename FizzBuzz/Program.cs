// See https://aka.ms/new-console-template for more information

using System.Text;

Dictionary<int, string> map =  new Dictionary<int, string>();
map[3] = "FIZZ";
map[4] = "BUZZ";

var res = Solution.FizzBuzz(12, map);

Console.WriteLine("Hello, World! "+res);

class Solution
{
    public static string FizzBuzz(int numbers, Dictionary<int, string> map)
    {
        StringBuilder sb = new StringBuilder();
        foreach(var kv in map)
        {
            if(numbers %  kv.Key == 0)
            {
                sb.Append(kv.Value);
            }
        }

        if(sb.Length == 0) return numbers.ToString();

        return sb.ToString();
    }
}