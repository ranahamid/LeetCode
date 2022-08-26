using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CodeSignal
{
    internal class Century
    {
        int solution(int year)
        {
            return (int)GetDivideVal(year);
        }
        public static double GetDivideVal(int year)
        {
            return Math.Ceiling(year / 100.0);
        }
    }
}
