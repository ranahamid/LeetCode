using System;

namespace LeetCode
{
    public class _762__Prime_Number_of_Set_Bits_in_Binary_Representation {


        /// <summary>
        /// Runtime: 66 ms, faster than 77.78% of C# online submissions for Prime Number of Set Bits in Binary Representation.
        /// Memory Usage: 25.1 MB, less than 100.00% of C# online submissions for Prime Number of Set Bits in Binary Representation.
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static int CountPrimeSetBits(int left, int right)
        { 
            int count = 0;
            for (int i = left; i <= right; i++)
            {
                var numberOfBits = 0;
                var temp = i;
                while (temp>0)
                {
                    numberOfBits = numberOfBits + (temp & 1);
                    temp = temp >> 1;
                }

                if (IsPrime(numberOfBits))
                {
                    count++;
                }
            }

            return count;
        }

        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));
          
            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;
    
            return true;        
        }


    }
}