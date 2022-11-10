using System;
using System.Collections.Generic;

namespace LeetCode.Z
{
    public class _2243__Calculate_Digit_Sum_of_a_String
    {

        public static string DigitSum(string s, int k)
        {
            var sChars = s.ToCharArray();
            while (sChars.Length > k)
            {
                var sValue = new string(sChars);
                var totalLen = sChars.Length;
                var len = totalLen / k;
                int startIndex = 0;
                var sumValue = new List<string>();
                for (int i = 0; i < len; i++)
                {
                    var subsWord = sValue.Substring(startIndex, k);
                    startIndex = startIndex + k;
                    var n = GetCalcVale(subsWord);
                    sumValue.Add(n.ToString());
                }

                var lastLength = totalLen - startIndex;
                if (lastLength > 0)
                {
                    var subs = sValue.Substring(startIndex, lastLength);
                    var m = GetCalcVale(subs);
                    sumValue.Add(m.ToString());
                }

                var st = "";
                foreach (var item in sumValue)
                {
                    st = st + item;
                }
                sChars = st.ToCharArray();
            }
            return new string(sChars);
        }

        public static int GetCalcVale(string num)
        {
            var sChars = num.ToCharArray();
            int sum = 0;
            for (int i = 0; i < sChars.Length; i++)
            {
                if (int.TryParse(sChars[i].ToString(), out int n))
                {
                    sum = sum + n;
                }
            }
            return sum;
        }

    }
}