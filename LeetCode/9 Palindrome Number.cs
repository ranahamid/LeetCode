using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Palindrome_Number
    {
        //Runtime: 53 ms, faster than 82.30% of C# online submissions for Palindrome Number.
        public static bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;
            var temp = x;
            var reversedNum = 0;
            //123
            while (temp > 0)
            {
                var lastDigit = temp % 10; //3
                temp = temp / 10;// 12
                reversedNum = reversedNum * 10 + lastDigit;
            }
            if (reversedNum == x)
                return true;
            return false;
        }
        //Runtime: 34 ms, faster than 99.64% of C# online submissions for Palindrome Number.
        public bool IsPalindrome_2(int x)
        {
            if (x < 0)
                return false;
            var temp = x;
            var reversedNum = 0;
            while (temp > 0)
            {
                reversedNum = reversedNum * 10 + temp % 10;
                temp = temp / 10;

            }
            if (reversedNum == x)
                return true;
            return false;
        }
        //Runtime: 89 ms, faster than 16.05% of C# online submissions for Palindrome Number.
        public static bool IsPalindrome_3(int x)
        {
            if (x < 0 || (x != 0 && x % 10 == 0))
                return false;

            var reversedNum = 0;
            //123
            while (x > reversedNum)
            {
                reversedNum = reversedNum * 10 + x % 10;
                x = x / 10;
            }
            if (reversedNum == x || x == reversedNum / 10)
                return true;
            return false;
        }
    }
}
