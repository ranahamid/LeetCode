using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_84
{
    internal class CalculateSum2
    {
       
	    int solution(int[] a, int[] b, int k) {

    var result=new List<long>();
    int i=0,j=b.Length-1;
    while(j>=0)
    {
        var st= long.Parse(a[i].ToString()+b[j].ToString());
        //Console.WriteLine(st);
        result.Add(st);
        i++;
        j--;
    }
    var counter=0;
    foreach(var item in result){
        if(item<k){
            counter++;
        }
    }
    return counter;
}


 
         
    }
}
