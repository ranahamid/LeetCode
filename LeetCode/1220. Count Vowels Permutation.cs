using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1220
    {
        /// <summary>
        /// Runtime: 28 ms, faster than 87.81% of C# online submissions for Count Vowels Permutation.
        /// Memory Usage: 25.3 MB, less than 85.37% of C# online submissions for Count Vowels Permutation.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int CountVowelPermutation(int n)
        {
            var MOD = (long)Math.Pow(10, 9) + 7;
            long aCount = 1, eCount = 1, iCount = 1, oCount = 1, uCount = 1;
            for (int i = 1; i < n; i++)
            {
                long aCountNew = 0, eCountNew = 0, iCountNew = 0, oCountNew = 0, uCountNew = 0;

                aCountNew = (eCount + iCount + uCount) % MOD;
                eCountNew = (aCount + iCount) % MOD;
                iCountNew = (eCount + oCount) % MOD;
                oCountNew = (iCount) % MOD;
                uCountNew = (iCount + oCount) % MOD;

                aCount = aCountNew;
                eCount = eCountNew;
                iCount = iCountNew;
                oCount = oCountNew;
                uCount = uCountNew;
            }

            return (int)((aCount + eCount + iCount + oCount + uCount) % MOD);
        }
    }
}
