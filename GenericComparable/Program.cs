// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


public class GenericCompare<T> where T : IComparable<T>
{
    public int Compare(T x, T y)
    {
        return x.CompareTo(y);
    }
}