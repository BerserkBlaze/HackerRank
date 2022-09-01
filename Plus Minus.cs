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
        int n = arr.Count;
        float positive_Elements = 0, negative_Elements = 0, zero_Elements = 0;
        
        for (int i = 0; i < n; i++){
            if(arr[i]>0){
                positive_Elements++;
            }
            else if(arr[i]<0){
                negative_Elements++;
            }else{
                zero_Elements++;
            }
        }
        
        Console.WriteLine((positive_Elements/arr.Count).ToString("0.000000") +Environment.NewLine+ (negative_Elements/arr.Count).ToString("0.000000")       +Environment.NewLine+ (zero_Elements/arr.Count).ToString("0.000000"));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
