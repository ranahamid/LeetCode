using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Amazon
{
    internal class powerful_processor
    {
        /// <summary>
        /// https://leetcode.com/discuss/interview-question/2380691/Amazon-OA-SDE-New-Grad
        /// A list of processors with 3 variables are given. X = [1,1,3], Y = [4,3,4], Z = [5,6,7]. 
        /// Here there are 3 processors each with its X, Y, Z. Return the list of powerful processors. 
        /// A weak processor is defined with X1,Y1, Z1 
        /// if there exists a processor with specs X2,Y2,Z2 such that X1 = X2, Y1 > Y2, Z1 < Z2. 
        /// Return only powerful processors. Here result is [2,3] . 1-based indexing.
        /// 
        ///1 <= n <= 10^5
        ///1 <= x[i],Y[i],Z[i] <= 10^9
        ///TLE: O(n^2)
        /// </summary>
        /// <param name="properties"></param>
        /// <returns></returns>
        public List<int> PowerfulProcessors(int[][] properties)
        {

            properties = properties.OrderByDescending(x => x[0]).OrderBy(x => x[1]).OrderBy(x => x[2]).ToArray();

            var maxValue1 = Int32.MaxValue;
            var maxValue2 = Int32.MinValue;
            var result = new List<int>();
            for (int i = 0; i < properties.Length; i++)
            {
                var item = properties[i];
                var first = false;
                var second = false;
                if (item[1] > maxValue1)
                {
                    first = true;
                }
                else
                {
                    maxValue1 = item[1];
                }
                if (item[2] > maxValue2)
                {
                    second = true;
                }
                else
                {
                    maxValue2 = item[2];
                }
                if (first && second)
                    result.Add(i + 1);
            }
            return result;
        }
    }
}
