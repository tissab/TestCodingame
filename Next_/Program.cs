using System.Text;

// See https://aka.ms/new-console-template for more information

Console.WriteLine(Solution.Next_(901)); 
//Console.WriteLine(Solution.Next(2));
//Console.WriteLine(Solution.Next(901));
//Console.WriteLine(Solution.Next(958));
//Console.WriteLine(Solution.Next(3025)); // 4111
//Console.WriteLine(Solution.Next(654321));


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
            Console.WriteLine(i);
            if (hashUniq) return i;
        }
        return -1;
    }

    public static int Next_(int n)
    {
        if (n <= 0 || n >= int.MaxValue) throw new ArgumentOutOfRangeException();

        if (n.ToString().Length == 1) return n + 1;

        StringBuilder sb = new StringBuilder();
       
        if(n.ToString().Length >= 2)
        {
           int i = 0;
           char d ;
           foreach(char c in n.ToString())
           {
                if (i > 0) d = '0';
                else d =c;

               sb.Append(Decompose(int.Parse(d.ToString()), n));

               i++;
                Console.WriteLine(i);
            }
        }

        return int.Parse(sb.ToString());
    }

    private static string Decompose(int i,int n)
    {
        if (n.ToString().ToCharArray().Any(x => i.ToString().Contains(x))) return Decompose((i+1),n);
        return i.ToString();
    }
}