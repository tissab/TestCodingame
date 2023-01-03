using System;
using System.Linq;

namespace Player
{
    class Program
    {
        static void Main(string[] args)
        {
            //var res = Player.ComputeMultipleSum(15);
            //var res = Player.Count(20000);
            //var res = Player.translate("hello, secret ");
            var res = Player.translate("meeting, tonight.");
            Console.WriteLine($"Hello World!  {res}");
        }
    }

    class Player
    {
        public static string Solve(int width, int height, int length, int mass)
        {
            bool xA = false;
            bool xB = false;

            if(width < 20 || height < 20 || length < 20 || width > 200 || height > 200 || length > 200 || mass < 10 || mass > 1000)
            {
                return string.Empty;
            }

            if(width * height * length > 1000000 || width >= 150 || height >= 150 || length >= 150)
            {
                xA = true;
            }

            if(mass >= 20)
            {
                xB = true;
            }

            if(xA == false && xB == false)
            {
                return "STANDARD";
            }

            if(xA == true || xB == true)
            {
                return "SPECIAL";
            }

            if(xA && xB)
            {
                return "REJECTED";
            }

            return "";
        }

        public static int ComputeMultipleSum(int n)
        {
            var i = 3;
            bool calc = false;
            int total = 0;
            while (true)
            {
                calc = false;

                if (i % 3 == 0)
                {
                    calc = true;
                }

                if (i % 5 == 0)
                {
                    calc = true;
                }

                if (i % 7 == 0)
                {
                    calc = true;
                }

                if (calc)
                {
                    if (i < n)
                    {
                        total = total + i;
                    }
                    else
                    {
                        break;
                    }
                }
                i++;
            }

            return total;
        }

        public static int Count(int n)
        {
            int res = 0;
            while(n > 0)
            {
                res = res + n - 1;
                n--;
            }

            return res; 
        }

        public static string translate(string text)
        {
            var arr = text.ToCharArray();

            var arrVoyelle = new char[] { 'a', 'e', 'i', 'o', 'u' };

            string textCrypte = string.Empty;

            int a = 0;

            for(int i = 0; i < arr.Length; i++)
            {
                var res = arrVoyelle.Any(x => x.Equals(arr[i]));

                if (res && a < 1)
                {
                    textCrypte = textCrypte + "av" + arr[i];
                    a++;
                }
                else
                {
                    textCrypte = textCrypte + arr[i];
                    a = 0;
                }

            }

            return textCrypte;
        }
    }
}
