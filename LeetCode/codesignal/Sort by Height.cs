using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.codesignal
{
    internal class Sort_by_Height
    {
        int[] solution(int[] a)
        {
            var list= new List<int>();
            foreach(var item in a)
            {
                if(item !=-1)
                    list.Add(item);
            }
            list.Sort();
            var counter = 0;
            for(int i = 0; i < a.Length; i++)
            {
                if(a[i] != -1)
                {
                    a[i] = list[counter++];
                }
            }
            return a;
        }

    }
}
