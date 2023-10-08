// See https://aka.ms/new-console-template for more information
using System.Data;
using System.Linq.Expressions;
using System.Text.RegularExpressions;


var res = Solution.ApplyFunction("2x²+2x+3", 4);
Console.WriteLine("Hello, World!");


internal  class Solution
{
    public static int ApplyFunction(string quadraticFunction, int x)
    {
        var calc = quadraticFunction.Replace("x", $"*{x}").Replace("²",$"*{x}");

        var result = (int)new DataTable().Compute(calc, null); 

        return result;
    }
}