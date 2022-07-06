using System;

namespace LeetCode
{
    /// <summary>
    /// Runtime: 42 ms, faster than 18.18% of C# online submissions for Number Complement.
    /// Memory Usage: 25.3 MB, less than 61.82% of C# online submissions for Number Complement.
    /// </summary>
    public class _476__Number_Complement {
        
        public static int FindComplement(int num)
        {
            int sum = 0;
            int counter = 0;
            while (num>0)
            {
                var bit = num & 1;
                if (bit == 0)
                {
                    sum = sum + (int)Math.Pow(2, counter);
                }
                counter++;
                num = num >> 1;
            }

            return sum;
        }
    }
}