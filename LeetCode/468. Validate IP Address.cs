using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _468
    {
        /// <summary>
        /// Runtime: 93 ms, faster than 82.93% of C# online submissions for Validate IP Address.
        /// Memory Usage: 40.6 MB, less than 7.32% of C# online submissions for Validate IP Address.
        /// </summary>
        /// <param name="queryIP"></param>
        /// <returns></returns>
        public string ValidIPAddress(string queryIP)
        {
            Regex validateIPv4Regex = new Regex(@"^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$");
            if (validateIPv4Regex.IsMatch(queryIP))
                return "IPv4";
            Regex validateEmailRegex = new Regex(@"^(?:[A-F0-9]{1,4}:){7}[A-F0-9]{1,4}$");
            if (validateEmailRegex.IsMatch(queryIP.ToUpper()))
                return "IPv6";
            return "Neither";
        }
    }
}
