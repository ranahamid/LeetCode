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

        #region divide & con
        public string ValidIPAddress(string queryIP)
        {
            if (queryIP.Count(x => x == '.') == 3)
                return ValidateIP4(queryIP);

            if (queryIP.Count(x => x == ':') == 7)
                return ValidateIP6(queryIP);
            return "Neither";
        }
        public string ValidateIP4(string queryIP)
        {
            var words = queryIP.Split(".");
            foreach (var item in words)
            {
                if (item.Length == 0 || item.Length > 3)
                    return "Neither";
                if (item.Length != 1 && item[0] == '0')
                    return "Neither";
                foreach (var ch in item)
                {
                    if (!char.IsDigit(ch))
                        return "Neither";
                }
                if (Int32.TryParse(item, out int ip))
                {
                    if (ip < 0 || ip > 255)
                        return "Neither";
                }
            }
            return "IPv4";
        }
        public string ValidateIP6(string queryIP)
        {
            var hex = "0123456789ABCDEFabcdef";
            var words = queryIP.Split(":");
            foreach (var item in words)
            {
                if (item.Length == 0 || item.Length > 4)
                    return "Neither";
                foreach (var ch in item)
                {
                    if (!hex.Contains(ch))
                        return "Neither";
                }

            }
            return "IPv6";
        }
        #endregion
        /// <summary>
        /// Runtime: 93 ms, faster than 82.93% of C# online submissions for Validate IP Address.
        /// Memory Usage: 40.6 MB, less than 7.32% of C# online submissions for Validate IP Address.
        /// </summary>
        /// <param name="queryIP"></param>
        /// <returns></returns>
        public string ValidIPAddress_Regex(string queryIP)
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
