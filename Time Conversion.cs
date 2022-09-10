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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        string result_String="";
        
        if(s[s.Length-2]=='A'){
            if(s.Substring(0,2)=="12"){
                result_String= "00"+s.Substring(2,6);
            }else{
                result_String= s.Substring(0,8);
            }
        } else if(s[s.Length-2]=='P'){
            if(s.Substring(0,2)=="12"){
                result_String= s.Substring(0,8);
            }else{
                result_String= Convert.ToInt64(s.Substring(0,2))+12+s.Substring(2,6);
            }
            
        }
        return result_String;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
