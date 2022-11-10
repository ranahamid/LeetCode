using System;

namespace LeetCode.Z
{
    public class _1009__Complement_of_Base_10_Integer
    {
        public int BitwiseComplement(int n)
        {
            int sum = 0;
            int counter = 0;
            if (n == 0)
                return 1;
            while (n > 0)
            {
                var bit = n & 1;
                if (bit == 0)
                {
                    sum = sum + (int)Math.Pow(2, counter);
                }
                counter++;
                n = n >> 1;
            }

            return sum;
        }
    }
}