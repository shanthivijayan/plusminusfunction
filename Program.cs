using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
        decimal zero = 0;
        decimal positive = 0;
        decimal negative = 0;
        for (int i = 0; i < arr.Count; i++)
        {
            //Console.WriteLine(arr[i]);
            if (arr[i] == 0)
            {
                zero = zero + 1;

            }
            else if (arr[i] < 0)
            {
                negative = negative + 1;
            }
            else if (arr[i] > 0)
            {
                positive = positive + 1;
            }

        }
        //Console.WriteLine(zero);
        //Console.WriteLine(positive);
        //Console.WriteLine(negative);
        //Console.WriteLine(arr.Count);

        decimal zeropro;
        zeropro = zero / arr.Count;
        decimal pospro;
        pospro = positive / arr.Count;
        decimal negpro;
        negpro = negative / arr.Count;

        Console.WriteLine($"{pospro:0.000000}");
        Console.WriteLine($"{negpro:0.000000}");
        Console.WriteLine($"{zeropro:0.000000}");

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Number of Elements to find the proposition");
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        Console.WriteLine("Enter the Elements");
        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
