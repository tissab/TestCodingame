using System;
using System.Linq;

namespace RendreMonnaie
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = Solution.OptimalChange(33);
            Console.WriteLine($"Le resultat est : {res.ToString()}");
        }
    }

    class Change
    {
        public long coin2 = 0;
        public long bill5 = 0;
        public long bill10 = 0;

        public override string ToString()
        {
            return $"coin2 2 : {coin2} - bill 5 :{bill5} - bill 10 : {bill10}";
        }
    }

    class Solution
    {
        public static Change OptimalChange(long s)
        {
            Change change = new Change();

            if (s % 2 == 1) 
            {
                s -= 5;
                if (s < 0) {
                    return null;
                }
                change.bill5 = 1;
            }
            change.bill10 = s / 10;
            change.coin2 = (s % 10) / 2;
        
            return change;
        }

        public static int RendreLaMonnaie(int purchases, int amount_paid)
        {
            int monnaie = 0;
            int billet20 = 0;
            int billet10 = 0;
            int billet5 = 0;
            int coin2 = 0;
            int coin1 = 0;

            if (amount_paid < purchases)
            {
                Console.WriteLine("Vous n'avez pas payer suffisament");
                return -1;
            }
            else if (purchases == amount_paid)
            {
                Console.WriteLine("Pas ed monnaie à rendre");
                return 0;
            }
            else
            {
                monnaie = amount_paid - purchases;

                billet20 = monnaie / 20;
                monnaie = monnaie % 20;

                billet10 = monnaie / 10;
                monnaie = monnaie % 10;

                billet5 = monnaie / 5;
                monnaie = monnaie % 5;

                coin2 = monnaie / 2;
                monnaie = monnaie % 2;

                coin1 = monnaie / 1;
                monnaie = monnaie % 1;

                if (billet20 > 0)
                {
                    Console.WriteLine("Billet(s) de 20€");
                }
                if (billet10 > 0)
                {
                    Console.WriteLine("Billet(s) de 10€");
                }
                if (billet5 > 0)
                {
                    Console.WriteLine("Billet(s) de 5€");
                }
            }
            return 0;

        }
    }
}
