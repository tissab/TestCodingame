using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {

            //DateTime now = DateTime.Now.ParseExact("2020-01-03", "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            //string formattedDate = now.ToString("yyyy-MM-dd");
            //Console.WriteLine(formattedDate);

            Console.WriteLine("Hello World!");

           

            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            var last = numbers[^1];     // => 8
            var res  = numbers[1..];    // => 2,3,4,5,6,7,8
            var res0 = numbers[1..^1];  // => 2,3,4 5,6,7
            var res1 = numbers[1..4];   // => 2,3,4
            var res2 = numbers[3..7];   // => 4,5,6,7
            var res3 = numbers[^6..^1]; // => 3,4,5,6,7
            var res4 = numbers[0..3];   // => 1,2,3
            var res5 = numbers[^4..^1]; // => 5,6,7
            var res6 = numbers[^3..^0]; // => 6,7,8
            var res7 = numbers[^3..^1]; // => 6,7

            var res8 = "208260013823232"[0..5];

            bool SecondOperand()
            {
                Console.WriteLine("Second operand is evaluated.");
                return true;
            }

            var res9 = "208260013823232".StartsWith("20826") && SecondOperand();

            var res10 = typeof(Grade).IsEnumDefined(5);

            // Methode d'utilisation
            Console.WriteLine(5.ToEnum<Grade>());

        }

    }

    public enum Grade 
    {
        A = 5, B = 4, C = 3, D = 2, F = 1
    }

    // Methode d'extension des types Enum
    public static class ExtensionMethods
    {
        public static TEnum ToEnum<TEnum>(this int value)
        {
            if (typeof(TEnum).IsEnumDefined(value))
                return (TEnum)(object)value;
            return default;
        }
    }


   
    interface CapableDeVoler
    {
        void vole();
    }

    abstract class Avion : CapableDeVoler
    {
        public abstract void vole();
    }

    abstract class Oiseau : CapableDeVoler
    {
        public abstract void vole();
    }
}
