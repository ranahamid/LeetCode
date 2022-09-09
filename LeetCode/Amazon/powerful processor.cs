using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Amazon
{
    internal class powerful_processor
    {
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
