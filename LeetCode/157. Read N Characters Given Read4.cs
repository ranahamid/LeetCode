using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    ///Runtime: 126 ms, faster than 29.03% of C# online submissions for Read N Characters Given Read4.
    ///Memory Usage: 35.8 MB, less than 41.94% of C# online submissions for Read N Characters Given Read4.
     

    //public class Solution : Reader4
    //{
    //    public int Read(char[] buf, int n)
    //    {
    //        int copyCharNum = 0, readChars = 4;
    //        char[] chars = new char[4];
    //        while (readChars == 4 && copyCharNum < n)
    //        {
    //            readChars = Read4(chars);
    //            for (int i = 0; i < readChars; i++)
    //            {
    //                if (copyCharNum == n)
    //                    return n;
    //                buf[copyCharNum++] = chars[i];
    //            }
    //        }
    //        return copyCharNum;
    //    }
    //}
}
