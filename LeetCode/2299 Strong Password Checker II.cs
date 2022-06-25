using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2299_Strong_Password_Checker_II
    {
        /// <summary>
        /// Runtime: 130 ms, faster than 33.14% of C# online submissions for Strong Password Checker II.
        /// Memory Usage: 36.5 MB, less than 82.29% of C# online submissions for Strong Password Checker II.
        /// </summary>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool StrongPasswordCheckerII(string password)
        {


            var chars = password.ToCharArray();
            var len = chars.Length;
            if (len < 8)
                return false;
            var specical = "!@#$%^&*()-+";
            bool isLower = false, isUpper = false, isDigit = false, isSpecial = false;

            for (int i = 0; i < len; i++)
            {
                if (char.IsLower(chars[i]))
                    isLower = true;
                if (char.IsUpper(chars[i]))
                    isUpper = true;
                if (char.IsDigit(chars[i]))
                    isDigit = true;
                if (specical.Contains(chars[i]))
                    isSpecial = true;
                if (i > 0 && chars[i - 1] == chars[i])
                    return false;
            }
            if (isLower && isUpper && isDigit && isSpecial)
            {
                return true;
            }
            return false;
        }
    }
}
