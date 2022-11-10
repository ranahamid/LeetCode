using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2303
    {
        public static double CalculateTax(int[][] brackets, int income)
        {
            if (income == 0)
                return 0;
            int lowLimit = 0;
            double vat = 0.0;

            for (int i = 0; i < brackets.Length; i++)
            {
                var upperLimit = brackets[i][0];
                var taxPercent = brackets[i][1];
                var inPathCount = upperLimit - lowLimit;
                var taxVal = 0;
                if (income > inPathCount)
                {
                    taxVal = inPathCount;
                    income = income - inPathCount;
                }
                else
                {
                    taxVal = income;
                    income = 0;
                }
                vat += taxVal * taxPercent / 100.0;
                if (income == 0)
                    break;
                //next
                lowLimit = upperLimit;
            }

            return vat;
        }


    }
}
