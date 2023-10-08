using System;
using System.Collections.Generic;

namespace Check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var res1 = Check("[()]"); // true
            var res2 = Check("(()[])"); // true
            var res3 = Check("([)]"); // false
            var res4 = Check("(("); // false
            var res5 = Check("[(()])"); // false
            var res6 = Check("([(([[(([]))]]))])"); // true
            var res7 = Check("[](()()[[]])()[]([])"); // true
            var res8 = Check("([((([(([]))]))))))])"); // false
            var res9 = Check("[](()()[[]])[][[([])"); // false
            Console.WriteLine("Hello World!");

            // stack is LIFO => Last In First Out => Premier Entre , Sort en Dernier
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
