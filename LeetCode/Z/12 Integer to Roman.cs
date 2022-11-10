using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _12_Integer_to_Roman
    {
        /// <summary>
        /// Runtime: 117 ms, faster than 42.57% of C# online submissions for Integer to Roman.
        /// Memory Usage: 37.8 MB, less than 63.74% of C# online submissions for Integer to Roman.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static string IntToRoman(int num)
        {
            Dictionary<int, string> result = new Dictionary<int, string>();
            result.Add(1, "I"); result.Add(4, "IV"); result.Add(5, "V"); result.Add(9, "IX");
            result.Add(10, "X"); result.Add(40, "XL"); result.Add(50, "L"); result.Add(90, "XC");
            result.Add(100, "C"); result.Add(400, "CD"); result.Add(500, "D"); result.Add(900, "CM");
            result.Add(1000, "M");
            StringBuilder sb = new StringBuilder();
            for (int i = result.Count() - 1; i >= 0; i--)
            {
                while (num >= result.ElementAt(i).Key)
                {
                    sb.Append(result.ElementAt(i).Value);

                    num -= result.ElementAt(i).Key;
                }
            }
            return sb.ToString();
        }
    }
}
