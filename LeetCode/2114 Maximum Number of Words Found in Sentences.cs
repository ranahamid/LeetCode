using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2114_Maximum_Number_of_Words_Found_in_Sentences
    {  /// <summary>
       /// Runtime: 93 ms, faster than 86.88% of C# online submissions for Maximum Number of Words Found in Sentences.
       /// Memory Usage: 41.5 MB, less than 8.95% of C# online submissions for Maximum Number of Words Found in Sentences.
       /// </summary>
       /// <param name="sentences"></param>
       /// <returns></returns>
        public int MostWordsFound(string[] sentences)
        {
            int max = 0;
            foreach (var item in sentences)
            {
                var data = item.Split(' ');
                max = Math.Max(max, data.Length);
            }
            return max;
        }
    }
}
