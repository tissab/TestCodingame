// See https://aka.ms/new-console-template for more information


using System.Runtime.ConstrainedExecution;

string output = String.Concat(Code.GetAlphabet(true).Where(letter =>
                letter.CompareTo("J") >= 0));
Console.WriteLine(output);

//Code.GetAlphaber_V1('J');



public class Code
{
    public static List<string> GetAlphabet(bool upper)
    {
        List<string> alphabet = new List<string>();
        int charValue = upper ? 65 : 97;
        for (int ctr = 0; ctr <= 25; ctr++)
            alphabet.Add(((char)(charValue + ctr)).ToString());
        return alphabet;
    }

    public static void GetAlphaber_V1(char ctr)
    {
        for(char s = 'A'; s <= 'Z'; s++)
        {
            if(s >= ctr)
            {
                Console.WriteLine(s.ToString());
            }
        }
    }
}
// The example displays the following output:
//      MNOPQRSTUVWXYZ