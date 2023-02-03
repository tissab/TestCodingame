using System;

namespace CalcArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6 };

            Console.WriteLine($"Hello World! {CalcArray.Calc(array,0,5)}");
        }
    }

    class CalcArray
    {
        public static int Calc(int[] array, int n1, int n2)
        {
            int total = 0;
            int index = 0;

            foreach (int element in array)
            {
                if (index >= n1 && index <= n2)
                {
                    total += element;
                    index++;
                }
            }

            // OU

            //  int retour = array.Where((a, i) => i >= n1 && i <= n2).Sum();


            return total;
        }
    }

    class Base
    {
        public virtual void Foo() { }
    }

    class Bar: Base
    {
        public sealed override void Foo()
        {
            base.Foo();
        }
    }
}
