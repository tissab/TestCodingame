// See https://aka.ms/new-console-template for more information

using System.Text;

var res = Solution.Encode("aabaa");

Console.WriteLine($"Hello, World! {res}");


class Solution
{
    public static string Encode(string plaintext)
    {
       var arrayChar = string.Join("",plaintext.Concat(" ")).ToCharArray();

        StringBuilder stringBuilder= new StringBuilder();

        int cpt = 0;

        for(int i = 0; i < arrayChar.Length; i++)
        {
            ++cpt;
            for(int j = i+1; j < arrayChar.Length; j++)
            {
                char xi = arrayChar[i];
                char xj = arrayChar[j];

                if (xi == xj)
                {
                    cpt++;
                }
                else
                {
                    stringBuilder.Append($"{cpt}{xi}");
                    i = j-1;
                    cpt = 0;
                    break;
                }
            }
        }
        return stringBuilder.ToString();
    }
}