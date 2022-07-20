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
     
    public static void miniMaxSum(List<int> arr)
    {
        arr.Sort();
        long totalSum = 0;
        foreach (var item in arr)
        {
            totalSum += item;
        }
        Console.WriteLine($"{totalSum - arr.LastOrDefault()} {totalSum - arr.FirstOrDefault()}");
    }

} 
 
