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
     * Complete the 'pageCount' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER p
     */

    public static int pageCount(int n, int p)
    {
        int lastPage=0, pPage=0, resultPage=0;
        
        if(p%2==0){
            pPage=(p+2)/2;
        } else {
            pPage=(p+1)/2;
        }
        if(n%2==0){
            lastPage=(n+2)/2;
        } else {
            lastPage=(n+1)/2;
        }
        
        resultPage=Math.Abs(pPage-1);
        if(Math.Abs(pPage-lastPage) < resultPage){
            resultPage = Math.Abs(pPage-lastPage);
        }
        Console.WriteLine("lastPage"+lastPage+", pPage"+pPage+", resultPage"+resultPage);
        return resultPage;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        int p = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result.pageCount(n, p);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
