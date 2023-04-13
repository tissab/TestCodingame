// See https://aka.ms/new-console-template for more information

using System.Runtime.Intrinsics.Arm;
using System.Text;
using System;
using Microsoft.VisualBasic;
using System.Net.NetworkInformation;

// [1,2,1] = 1
//[1,1,5] = 2
//[1,1,3,2,3,2] = 3

var res = code.Solution(new List<int> { 1, 1, 5 });

Console.WriteLine($"Hello, World! {res}");

class code
{
    /// <summary>
    /// Le but de cet exercice est de renvoyer Le nombre Magic Specifiations :
    /// </summary>
    /// <param name="stones[]"></param>
    /// <returns>string</returns>
    public static int Solution(List<int> tab)
    {
        List<int> list = tab.ToList();

        list.Sort();
        int i = 0;
        while (i < list.Count - 1)
        {
            if (list[i] == list[i + 1])
            {
                list.RemoveAt(i + 1);
                int a = list[i];
                list.RemoveAt(i);
                list.Add(a + 1);
                list.Sort();
                i = 0;
            }
            else
            {
                i++;
            }
        }
        return list.Count;
    }



}