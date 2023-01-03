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
            return $"coin2 :{coin2} - bill5 :{bill5} - bill10 :{bill10}";
        }
    }

    class Solution
    {
        public static Change OptimalChange(long s)
        {
            Change change = new Change();

            int[] moneyArr = { 10, 5, 2, 0 };

            bool res = false;

            int i = 0;

            while(i <= moneyArr.Length)
            {
                if (s >= moneyArr[i])
                {
                    if (moneyArr[i] == 0)
                    {
                        break;
                    }
                    res = moneyArr.Any(x => x == (s - moneyArr[i]) % moneyArr[i]);
                    if(res == false)
                    {
                        res = moneyArr.Any(x => x == (s - moneyArr[i]) % 2);
                    }
                    if(res == true)
                    {
                        s = s - moneyArr[i];
                        if(s >= 0)
                        {
                            switch (moneyArr[i])
                            {
                                case 2:
                                    change.coin2 = change.coin2 + 1;
                                    break;
                                case 5:
                                    change.bill5 = change.bill5 + 1;
                                    break;
                                case 10:
                                    change.bill10 = change.bill10 + 1;
                                    break;
                            }
                        }
                        if(s >= moneyArr[0])
                        {
                            i = 0;
                            continue;
                        }

                        if(s >= moneyArr[1])
                        {
                            i = 1;
                            continue;
                        }

                        if(s >= moneyArr[2])
                        {
                            i = 2;
                            continue;
                        }
                    }
                }

                i++;
            }
            return change;
        }
    }
}
