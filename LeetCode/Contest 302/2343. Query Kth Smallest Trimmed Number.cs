using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_302
{
    internal class _2343
    {
        public class NumberFormat
        {
            public int Index { get; set; }
            public string ValueNum { get; set; }
        }

        /// <summary>
        /// Runtime: 2681 ms, faster than 100.00% of C# online submissions for Query Kth Smallest Trimmed Number.
        /// Memory Usage: 46.9 MB, less than 100.00% of C# online submissions for Query Kth Smallest Trimmed Number.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="queries"></param>
        /// <returns></returns>
        public int[] SmallestTrimmedNumbers(string[] nums, int[][] queries)
        {
            var result = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = nums[i].Trim();
            }
            foreach (var item in queries)
            {
                var listNum = new List<string>();
                for (int i = 0; i < nums.Length; i++)
                {
                    var data = nums[i].Substring(nums[i].Length - item[1]);
                    listNum.Add(data);
                }
                //smallest number 2,3,1,4
                var index = GetSmallestElement(listNum, item[0]);
                result.Add(index);
            }
            return result.ToArray();
        }
        public static int GetSmallestElement(List<string> listNum, int nTh)
        {
            var list = new List<NumberFormat>();
            var counter = 0;
            foreach (var ite in listNum)
            {
                list.Add(new NumberFormat { Index = counter++, ValueNum = ite });
            }
            list = list.OrderBy(x => x.ValueNum).ThenBy(x => x.Index).ToList();
            var item = list[nTh - 1];
            return item.Index;
        }
        /*
        public static int GetSmallestElement(List<BigInteger> listNum, int nTh)
        {
            var sorted = new List<BigInteger>();
            foreach (var item in listNum)
            {
                sorted.Add(item);
            }
            sorted.Sort();
            var temp = new List<BigInteger>();
            for (int i = 0; i < nTh - 1; i++)
            {
                temp.Add(sorted[i]);
            }

            for (int i = 0; i < listNum.Count; i++)
            {
                var a = listNum[i];
                var b = sorted[nTh - 1];
                if (a == b)
                {
                    if (temp.Contains(a))
                    {
                        temp.Remove(a);
                        continue;
                    }
                    return i;
                }
            }
            return -1;
        }
        */
    }
}
