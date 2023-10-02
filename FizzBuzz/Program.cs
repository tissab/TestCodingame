// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

class Solution
{
    public static string FizzBuzz(int numbers, Dictionary<int, string> map)
    {
        var query = (
            from i in Enumerable.Range(1, numbers)
            let output = string.Concat(map.Where(x => i % x.Key == 0).Select(x => x.Value))
            select output == "" ? i.ToString() : output
            );
        return string.Join(" ", query);
    }
}