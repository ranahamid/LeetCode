using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2515
    {
        public int ClosetTarget(string[] words, string target, int startIndex)
        {
            var min = Int32.MaxValue;
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == target)
                {
                    var temp = Math.Abs(startIndex - i);
                    min = Math.Min(min, temp);
                    min = Math.Min(min, words.Length - temp);
                }
            }
            return min == Int32.MaxValue ? -1 : min;
        }
    }
}
