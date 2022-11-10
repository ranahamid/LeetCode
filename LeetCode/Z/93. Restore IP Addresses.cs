using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _93
    {
        /// <summary>
        /// Runtime: 279 ms, faster than 6.54% of C# online submissions for Restore IP Addresses.
        /// Memory Usage: 42.5 MB, less than 65.36% of C# online submissions for Restore IP Addresses.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public IList<string> RestoreIpAddresses(string s)
        {
            var len = s.Length;
            var result = new List<string>();
            for (int i = 1; i < 4 && i < len - 2; i++)
            {
                for (int j = i + 1; j < i + 4 && j < len - 1; j++)
                {
                    for (int k = j + 1; k < j + 4 && k < len; k++)
                    {
                        var s1 = s.Substring(0, i);
                        var s2 = s.Substring(i, j - i);
                        var s3 = s.Substring(j, k - j);
                        var s4 = s.Substring(k, len - k);
                        if (IsValid(s1) && IsValid(s2) && IsValid(s3) && IsValid(s4))
                        {
                            result.Add($"{s1}.{s2}.{s3}.{s4}");
                        }
                    }
                }
            }
            return result;
        }
        public static bool IsValid(string segment)
        {
            var len = segment.Length;
            if (len < 1 || len > 3)
                return false;
            if (segment[0] == '0')
            {
                if (len == 1)
                    return true;
                return false;
            }
            else
            {
                var n = int.Parse(segment);
                if (n <= 255)
                    return true;
                return false;
            }
        }
    }
}
