﻿using System;
using System.Linq;

namespace ComputeCheckDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = ComputeCheckDigit("34");
            Console.WriteLine($"Hello World! {res}");
        }

        static int ComputeCheckDigit(string identificateurNumber)
        {
            int result = 0;

            var arrayNum = identificateurNumber.ToCharArray().Select(x => int.Parse(x.ToString())).ToList();

            // Somme de chiffre au position paire

            result += arrayNum.Where((_, i) => i % 2 == 0).Sum();

            // Multiplier par 3

            result = result * 3;

            // Ajouter des chiffres situés aux positions impaires

            result += arrayNum.Where((_, i) => i % 2 != 0).Sum();

            // Recupéré le dernier chiffre du resultat

            int lastNumber = result % 10;

            // Soustrayer le dernier chiffre à 10
            if(lastNumber == 0)
            {
                return 0;
            }
            return result = 10 - lastNumber;

        }
    }
}
