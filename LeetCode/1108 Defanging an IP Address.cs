using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1108_Defanging_an_IP_Address
    {
        /// <summary>
        /// Runtime: 87 ms, faster than 78.83% of C# online submissions for Defanging an IP Address.
        /// Memory Usage: 35.4 MB, less than 58.56% of C# online submissions for Defanging an IP Address.
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public static string DefangIPaddr_2(string address)
        {
            return address.Replace(".", "[.]");
        }

    }
}
