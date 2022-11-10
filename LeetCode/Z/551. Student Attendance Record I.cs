using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _551
    {
        /// <summary>
        /// Runtime: 106 ms, faster than 43.89% of C# online submissions for Student Attendance Record I.
        /// Memory Usage: 36.6 MB, less than 72.66% of C# online submissions for Student Attendance Record I.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool CheckRecord(string s)
        {
            int MaxLate = 0;
            int absentCount = 0, lateCount = 0;
            if (s == null || s.Length < 2)
                return true;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'P')
                {
                    lateCount = 0;
                }
                if (s[i] == 'L')
                {
                    lateCount++;
                }
                if (s[i] == 'A')
                {
                    absentCount++;
                    lateCount = 0;
                }
                MaxLate = Math.Max(MaxLate, lateCount);
            }
            if (absentCount < 2 && MaxLate < 3)
                return true;
            return false;
        }
    }
}
