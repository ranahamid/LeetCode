using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.string_algo
{
    internal class Beautiful_Binary_String
    {
        public static int beautifulBinaryString(string b)
        {
            var len = b.Length; //7
            var count = b.Replace("010", "").Count();//1
            return (len - count) / 3; //6/3=2
        }
    }
}
