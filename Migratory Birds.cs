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
     * Complete the 'migratoryBirds' function below.
     *     && i!=arr.Count-1
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int migratoryBirds(List<int> arr)
    {
        arr.Sort();
        int count=0, maxCount=1, number=arr[0],pastNumber=0,number_result=arr[0];
        
        for(int i=0;i<arr.Count;i++){                 
            if(arr[i]==number){
                count++;
                if(i==arr.Count-1){
                  if(count>maxCount){
                        maxCount=count;
                        number_result=number;
                    }else if(count==maxCount){
                        if(number_result>number){
                            number_result=number;
                        }
                    }  
                }
            }else{
                if(count>maxCount){
                    maxCount=count;
                    number_result=number;
                }else if(count==maxCount){
                    if(number_result>number){
                        number_result=number;
                    }
                }
                number=arr[i];
                count=1;
            }
        }
        
        return number_result;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
