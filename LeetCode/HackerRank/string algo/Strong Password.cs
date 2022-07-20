using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank
{
    internal class Strong_Password
    {
        public static int minimumNumber(int n, string password)
        {
            var chars = password.ToCharArray();
            var len = chars.Length;
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
            }
            var counter = 0;
            if (isLower == false)
                counter++;
            if (isUpper == false)
                counter++;
            if (isDigit == false)
                counter++;
            if (isSpecial == false)
                counter++;

            var toAddChar = 6 - len;
            return Math.Max(toAddChar, counter);
        }
    }
}
