using System;
using System.Collections.Generic;
namespace LeetCode
{
    public class _1974_Minimum_Time_to_Type_Word_Using_Special_Typewriter
    {
        /// <summary>
        /// Runtime: 83 ms, faster than 68.29% of C# online submissions for Minimum Time to Type Word Using Special Typewriter.
        /// Memory Usage: 34.8 MB, less than 41.46% of C# online submissions for Minimum Time to Type Word Using Special Typewriter.
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public static int MinTimeToType(string word)
        {
            var sChars = word.ToCharArray();
            int sum = sChars.Length;
            int currentPosition = 0;
            for (int i = 0; i < sChars.Length; i++)
            {
                var ch = sChars[i]-97; //z=26
                var min1 = Math.Abs(ch - currentPosition);
                var min2 = Math.Abs(26 - Math.Abs(ch-currentPosition));
                var min = Math.Min(min1, min2);
                sum += min;
                currentPosition = ch;
            }
            return sum;
        }


    }
}