// See https://aka.ms/new-console-template for more information

namespace ComputeMultiples
{
    public class ComputeMultiples
    {
        public static void Main(string[] args)
        {
            //var nEntier = new int[5] { 12, 4, 9, 10, 14 };
            int nRetour= computemultiplesSum(10);
        }
        public static int computemultiplesSum(int n)
        {
            int sum = 0;

            if (n >= 0 && n <= 100)
            {
                for (int i = 1; i < n; i++)
                {
                    if (i % 3 == 0 || i % 5 == 0 || i % 7 == 0)
                    {
                        sum += i;
                    }
                }
            }
            return sum;
        }
    }
}
