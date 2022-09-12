using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1754
    {
        public string LargestMerge(string word1, string word2)
        {
            StringBuilder sb = new StringBuilder();
            int i = 0, j = 0;
            int iLen = word1.Length, jLen = word2.Length;
            while (i < iLen && j < jLen)
            {
                if (word1[i] > word2[j])
                {
                    sb.Append(word1[i]);
                    i++;
                }
                else if (word1[i] < word2[j])
                {
                    sb.Append(word2[j]);
                    j++;
                }
                else
                {
                    sb.Append(word1[i]);//any one. because both of i & j is same
                    if (word1.Substring(i).CompareTo(word2.Substring(j)) > 0)
                        i++;
                    else
                        j++;
                }
            }
            if (i < iLen)
            {
                sb.Append(word1.Substring(i)); 
            }
            if (j < jLen)
            {
                sb.Append(word2.Substring(j)); 
            }
            return sb.ToString();
        }

        #region TLE
        public string LargestMerge_TLE(string word1, string word2)
        {
            if (word1.Length == 0 || word2.Length == 0)
                return word1 + word2;
            if (word1.CompareTo(word2) < 0)
            {
                (word1, word2) = (word2, word1);
            }
            return word1[0] + LargestMerge_TLE(word1.Substring(1, word1.Length - 1), word2);
        }
        #endregion
    }
}
