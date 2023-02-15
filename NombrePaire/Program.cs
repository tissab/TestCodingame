using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace NombrePaire
{
    class Program
    {
        static void Main(string[] args)
        {
            //var t = NombredePaires(3);
            Combinaison();
            Console.WriteLine("Hello World!");
        }

        public static int NombredePaires(int n)
        {
            if (n < 2 || n > 1000) return 0;
            if (n == 1) return 0;
            return ((n - 1) + NombredePaires(n - 1));
        }

        public static void NombredePaires()
        {
            var s1 = "abc";
            var s2 = "abcbabc";
            //var s1 = "rabbit";
            //var s2 = "rabbbit";

            /*
             
            1 - bcb  5 - acb  9 - abb
            2 - cba  6 - aba  10- aba
            3 - bab  7 - aab    - abb
            4-  abc  8 - abc
             
             */


            //a1b1c2 //a1c2b //a1b3a  //a1b5c //a4b5c6
            //a1b1b  //a1c2a //a1b3b  //
            //a1b1a  //a1c2b //a1b3c6 //
            //a1b1b  //a1c2c //      //
            //a1b1c6 //     //      //

            var t2 = s2.ToCharArray();
            var numberChar = s2.ToCharArray().Length - 1;
            var taille = s1.Length;
            List<string> find = new List<string>();
            StringBuilder builder = new StringBuilder();
            int ind = 0, i = 0;
            var y = s2.ToCharArray().Select((x, i) => new { x, i })
                                    .Where(obj => obj.x.Equals(s1.ToCharArray()[0]))
                                    .Select(x => x.i).ToList();
            
            while(ind < y.Count())
            {
                var tI = numberChar - y[ind];
                i = 0;
                while (i < tI) 
                {
                    builder.Append(s2.ToCharArray()[y[ind]]);
                    for(int j = i+1; j < (t2.Length - y[ind]); j++)
                    {
                        builder.Append(t2[j]);
                        if (builder.Length == taille)
                        {
                            find.Add(builder.ToString());
                            builder.Length -= 1;
                        }
                    }
                    if(builder.Length >= 2)
                    {
                            builder.Length -= 2;
                    }
                    i++;
                }
                ind++;
            }

            var res = find.Where(x => x.Equals("s1"));
           
        }

        public static void Combinaison()
        {
            //var s1 = "abc";
            var s1 = "bag";
            var t1 = s1.ToCharArray();
            //var s2 = "abcbabbc";
            var s2 = "babgbag";
            var t2 = s2.ToCharArray();

            var arrayIndex = t2.Select((x,i) => new {x,i})
                               .Where(obj => obj.x.Equals(t1[0]))
                               .Select(x => x.i).ToArray();

            int i = 0, e = 0, count = 0, b = 1;
            
            StringBuilder builder;

            if(arrayIndex.Count() > 1)
            {
                while(e < arrayIndex.Count())
                {
                    builder = new StringBuilder();
                    builder.Append(t2[arrayIndex[e]]);
                    var t = t2.Length - (arrayIndex[e] + 1);

                    while (i < t)
                    {
                        for(int j = i + arrayIndex[e] + 1; j < t2.Length; j++)
                        {
                        
                            builder.Append(t2[j]);

                            if(builder.ToString().Equals(s1.Substring(0, builder.Length)))
                            {
                                if (builder.Length == t1.Length)
                                {
                                    count += 1 ;
                                    builder.Length -= 1;
                                }
                            }
                            else if(builder.Length == t1.Length)
                            {
                                builder.Length -= 1;
                            }                                
                        }
                        builder.Length -= 1;
                        i++;
                    }
                    builder.Length -= 1;
                    e++;
                    i = 0;
                }
            }
            else
            {
               
                builder = new StringBuilder();
                builder.Append(t2[arrayIndex[e]]);
                
                for (int j = i + arrayIndex[e] + 1; j < t2.Length; j++)
                {
                    if (t2[j] == t2[j - 1])
                    {
                        b += 1;
                    }
                    builder.Append(t2[j]);

                    if (builder.ToString().Equals(s1.Substring(0, builder.Length)))
                    {
                        if (builder.Length == t1.Length)
                        {
                            count += 1 * b;
                            builder.Length -= 1;
                        }
                    }
                    else 
                    {
                        builder.Length -= 1;
                    }
                }
                builder.Length -= 1;
                i++;
                    
                builder.Length -= 1;
                e++;
                i = 0;
            }
            

        }
    }
}
