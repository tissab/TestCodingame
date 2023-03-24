using System;
using System.Collections.Generic;

namespace Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "[()]";
            string str2 = "(()[])";
            string str3 = "([)]";
            string str4 = "((";
            string str5 = "[(()])";

            string str6 = "([(([[(([]))]]))])";
            string str7 = "[](()()[[]])()[]([])";
            string str8 = "([((([(([]))]))))))])";
            string str9 = "[](()()[[]])[][[([])";

            var res = Check(str1);
            Console.WriteLine("Hello World!");
        }

        public static bool Check(string s)
        {
            Stack<char> stack = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == ']')
                {
                    if (stack.Count == 0)
                    {
                        return false; // il n'y a pas de parenthèse/crochet ouvrant correspondant
                    }
                    char top = stack.Pop();
                    if ((c == ')' && top != '(') || (c == ']' && top != '['))
                    {
                        return false; // les parenthèses/crochets ne correspondent pas
                    }
                }
            }
            return stack.Count == 0; // la pile doit être vide à la fin pour que la chaîne soit correcte
        }
    }
}
