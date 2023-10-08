using System;
using System.Collections.Generic;


namespace GenericComparer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myString = new GenericComparer<string>();
            var muInt = new GenericComparer<string>();
            Console.WriteLine("Hello World!");
        }
    }

    public class GenericComparer<T> : IComparer<T> where T : IComparable<T> 
    {
        public int Compare(T x, T y)
        {
            return x.CompareTo(y);
        }
    }
}
