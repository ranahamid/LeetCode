using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    //public class Solution : Reader4
    //{
    //    /// <summary>
    //    /// Runtime: 158 ms, faster than 97.92% of C# online submissions for Read N Characters Given read4 II - Call Multiple Times.
    //    /// Memory Usage: 43.7 MB, less than 10.42% of C# online submissions for Read N Characters Given read4 II - Call Multiple Times.
    //    /// </summary>
    //    char[] chars = new char[4];
    //    int size = 0;
    //    int pt = 0;
    //    public int Read(char[] buf, int n)
    //    {
    //        int copyCharNum = 0;
    //        while (copyCharNum < n)
    //        {
    //            while (pt == size)
    //            {
    //                pt = 0;
    //                size = Read4(chars);
    //                if (size == 0)
    //                    return copyCharNum;
    //            }
    //            buf[copyCharNum++] = chars[pt++];
    //        }
    //        return copyCharNum;
    //    }
    //}
}
