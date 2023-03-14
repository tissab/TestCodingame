
namespace test
{
    class shape { }
    class square : shape { }
    class circle : shape { }
    public class FilterDuplicates
    {
        
        static void Main (string[] args)
        {
            int[] nMontableau = new int[8] { 7, 3, 6, 4, 3, 3, 4, 9 };
            var nTableauDistinct = FilterDuplicate(nMontableau);

            foreach(var tab in nTableauDistinct)
                Console.WriteLine(tab);
        }
        public static int[] FilterDuplicate(int[] data)
        {

            return data.DistinctBy(p => p).ToArray();
        }
    }
}