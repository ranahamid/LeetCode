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

        public void display()
        {
            var resW2 = new string[]
                        {
                         "8331019423839036903","2215783497319194533","3244863164120264914","2723857887888553250","1069645833408356268","3799170975306313470","3300849027471666477","8896469467436127218","9595084104356246555","4601424390471226348","2777623221871959897","2660664761264162910","4830224756337097853","2239177595019260973","5704104074606481922","5158962343348888307","4957489822885409209","5533958195540658313","6712811206814843536","9775503283462317096","1975389311819120035","1292135637676764140","9838972337538013522","7609294617007602893","0186572359592634437","9236053726818307461","7264888050655615544","4990296885039745852","1417868535147288083"
                        };
            int[][] nums1 = new int[29][]
                            {
                            new int[2] {22,19},new int[2] {16,17},new int[2] {10,7},new int[2] {27,16},new int[2] {9,9},new int[2] {21,4},new int[2] {24,2},new int[2] {12,11},new int[2] {2,5},new int[2] {24,12},new int[2] {25,7},new int[2] {7,13},new int[2] {14,9},new int[2] {23,15},new int[2] {18,17},new int[2] {22,16},new int[2] {4,14},new int[2] {14,17},new int[2] {25,11},new int[2] {12,16},new int[2] {29,3},new int[2] {22,11},new int[2] {29,2},new int[2] {24,2},new int[2] {24,15},new int[2] {7,14},new int[2] {7,3},new int[2] {7,14},new int[2] {1,3}
                            };
            Console.WriteLine(SmallestTrimmedNumbers(resW2, nums1));
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
