﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2125
    {
        /// <summary>
        /// Runtime: 155 ms, faster than 74.55% of C# online submissions for Number of Laser Beams in a Bank.
       /// Memory Usage: 58.7 MB, less than 5.45% of C# online submissions for Number of Laser Beams in a Bank.
        /// </summary>
        /// <param name="bank"></param>
        /// <returns></returns>
        public int NumberOfBeams(string[] bank)
        {
            var isFirstFound = false;
            var totalCount = 0;
            var prevCount = 0;
            for (int i = 0; i < bank.Length; i++)
            {
                var ones = bank[i].ToCharArray().Count(x => x == '1');
                if (ones > 0)
                {
                    if (isFirstFound == false)
                        isFirstFound = true;
                    else
                    {
                        totalCount += prevCount * ones;
                    }
                    prevCount = ones;
                }
            }
            return totalCount;
        }
    }
}
