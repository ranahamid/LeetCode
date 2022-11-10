using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    class _2224
    {
        /// <summary>
        /// Runtime: 102 ms, faster than 37.50% of C# online submissions for Minimum Number of Operations to Convert Time.
        /// Memory Usage: 35.4 MB, less than 98.86% of C# online submissions for Minimum Number of Operations to Convert Time.
        /// </summary>
        /// <param name="current"></param>
        /// <param name="correct"></param>
        /// <returns></returns>
        public static int ConvertTime(string current, string correct)
        {
            var currentMin = GetMin(current);
            var correctMin = GetMin(correct);
            var diff = 0;
            if (correctMin > currentMin)
            {
                diff = correctMin - currentMin;
            }
            var counter = 0;
            while (diff > 0)
            {
                if (diff >= 60)
                    diff = diff - 60;
                else if (diff >= 15)
                    diff = diff - 15;
                else if (diff >= 5)
                    diff = diff - 5;
                else if (diff >= 1)
                    diff = diff - 1;
                counter++;
            }
            return counter;

        }
        public static int GetMin(string current)
        {
            var currentTime = current.Split(':');
            var currentMin = 0;
            if (int.TryParse(currentTime[0], out var time))
            {
                currentMin = time * 60;
            }
            if (int.TryParse(currentTime[1], out var time2))
            {
                currentMin = currentMin + time2;
            }
            return currentMin;
        }

    }
}
