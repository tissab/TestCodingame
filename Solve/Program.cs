// See https://aka.ms/new-console-template for more information



// To debug: Console.Error.WriteLine("Debug messages...");


using System.Text;

Console.WriteLine("Hello, World!");
class Calc
{
    public static int Solve(int weight0, int weight1, int weight2)
    {
        
        int[] poids = { weight0, weight1, weight2 };

        int t = 0;
        int j = 0;

        for(int i = 0; i < poids.Length; i++)
        {
            if(t < poids[i])
            {
                t = poids[i];
                j = i;
            }
        }
        return j;
    }



}