// See https://aka.ms/new-console-template for more information
using System.Text;

var res = p.Translate("codingame");

Console.WriteLine($"Hello, World! {res}");

class p
{
    public static string Translate(string text)
    {
        var arr = text.ToCharArray();

        StringBuilder sb = new StringBuilder();

        char[] voyelles = { 'a', 'e', 'i', 'o', 'u' };

        string str = string.Empty;

        bool voyelleTouvee = false;

        for(int i = 0; i< arr.Length; i++)
        {
            if(voyelles.Any(x => x == arr[i]))
            {
                if(voyelleTouvee is false)
                {
                    str = "av";
                    sb.Append(str);
                    voyelleTouvee = true;
                }
            }
            else
            {
                voyelleTouvee = false;
            }
            
            sb.Append(arr[i]);
            
        }

        return sb.ToString();
    }

}