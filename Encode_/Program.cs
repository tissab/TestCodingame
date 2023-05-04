// See https://aka.ms/new-console-template for more information

using System.Text;

var res = Solution.Encode_("aabbbcbbccca");

Console.WriteLine($"Hello, World! {res}");


class Solution
{
    public static string Encode_(string plaintext)
    {
        var arrayChar = string.Join("", plaintext.Concat(" ")).ToCharArray();

        StringBuilder stringBuilder = new StringBuilder();

        int cpt = 0;

        for (int i = 0; i <arrayChar.Length; i++)
        {
            if(i == 0)
            {
                cpt++;
                continue;
            }

            if (arrayChar[i-1] == arrayChar[i])
            {
                cpt++;
            }
            else
            {
                stringBuilder.Append($"{cpt}{arrayChar[i-1]}");
                cpt = 1;
            }
        }
        return stringBuilder.ToString();
    }
}