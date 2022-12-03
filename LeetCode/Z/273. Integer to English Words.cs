using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _273
    {
        Dictionary<int, string> dic = new Dictionary<int, string>();
        public string NumberToWords(int num)
        {
            dic.Add(1, "One");
            dic.Add(2, "Two");
            dic.Add(3, "Three");
            dic.Add(4, "Four");
            dic.Add(5, "Five");
            dic.Add(6, "Six");
            dic.Add(7, "Seven");
            dic.Add(8, "Eight");
            dic.Add(9, "Nine");
            dic.Add(10, "Ten");
            dic.Add(11, "Eleven");
            dic.Add(12, "Twelve");
            dic.Add(13, "Thirteen");
            dic.Add(14, "Fourteen");
            dic.Add(15, "Fifteen");
            dic.Add(16, "Sixteen");
            dic.Add(17, "Seventeen");
            dic.Add(18, "Eighteen");
            dic.Add(19, "Nineteen");
            dic.Add(20, "Twenty");

            dic.Add(30, "Thirty");
            dic.Add(40, "Forty");
            dic.Add(50, "Fifty");
            dic.Add(60, "Sixty");
            dic.Add(70, "Seventy");
            dic.Add(80, "Eighty");
            dic.Add(90, "Ninety");

            if (num == 0)
                return "Zero";
            string result = "";
            int counter = 0;
            string prefix = "";
            while (num > 0)
            {
                int digit = num % 1000;
                num /= 1000;

                if (counter == 1 && digit != 0)
                    prefix = " Thousand ";
                if (counter == 2 && digit != 0)
                    prefix = " Million ";
                if (counter == 3 && digit != 0)
                    prefix = " Billion ";
                result = NumberToString(digit).Trim() + prefix + result.Trim();
                counter++;
            }
            return result;

        }
        public string NumberToString(int num)
        {
            if (num == 0)
                return "";
            if (num < 21)
                return dic[num];
            if (num < 100) //72
                return dic[(num / 10) * 10] + " " + NumberToString(num % 10);
            return dic[(num / 100)] + " Hundred " + NumberToString(num - ((num / 100) * 100)); //725
        }
    }
}
