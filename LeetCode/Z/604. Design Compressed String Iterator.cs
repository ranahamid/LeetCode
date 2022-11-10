using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    public class StringIterator
    {
        /// <summary>
        /// Runtime: 153 ms, faster than 100.00% of C# online submissions for Design Compressed String Iterator.
        /// Memory Usage: 53.3 MB, less than 11.11% of C# online submissions for Design Compressed String Iterator.
        /// </summary>
        int n = 0, ptr = 0, length;
        char ch = ' ';
        string word;
        public StringIterator(string compressedString)
        {
            word = compressedString;
            n = 0;
            ptr = 0;
            length = word.Length;
        }

        public char Next()
        {
            if (!HasNext())
                return ' ';
            if (n == 0)
            {
                ch = word[ptr];
                ptr++;
                while (ptr < length && char.IsDigit(word[ptr]))
                {
                    n = n * 10 + int.Parse(word[ptr].ToString());
                    ptr++;
                }
            }
            n--;
            return ch;
        }

        public bool HasNext()
        {
            if (ptr != length || n != 0)
            {
                return true;
            }
            return false;
        }
    }

}
