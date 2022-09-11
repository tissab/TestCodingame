using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCodingame.Calculator
{
    class Calcul
    {
        public static string Sum(params string[] numbers)
        {
            var arr = numbers.Select(x => double.Parse(x, CultureInfo.InvariantCulture)).Sum();

            //double total = 0;

            //foreach(var number in arr)
            //{
            //    total = total + number;
            //}

            return arr.ToString();
        }
    }
}
