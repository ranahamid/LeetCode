using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_84
{
    internal class CalculateSum
    {
       
	    bool[] solution(int[] numbers, int left, int right) 
{

    bool[] result=new bool[numbers.Length  ];
    for(int i=0;i<numbers.Length;i++)
    {
        var isFalse=false;
        var num= numbers[i];
        var index=i+1;
        double val= Math.Round( (num/(index*1.00)),10);
         Console.WriteLine(val);
        if(val==(int)(val))
        {
           
            if(val>=left && val<=right)
                isFalse=true;
        }
     else{
           isFalse= false;
     }
        
         result[i]= isFalse;
    }
    return result;    
}

 
         
    }
}
