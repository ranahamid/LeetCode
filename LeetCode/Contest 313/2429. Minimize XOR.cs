using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_313
{
    internal class _2429
    {
        /// <summary>
        /// Runtime 39 ms Beats 100%
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public int MinimizeXor(int num1, int num2)
        {
            int setBits = GetSetBits(num2);// Convert.ToString(num2,2).Where(x=>x=='1').Count();
            Console.WriteLine(setBits);
            int result = 0;
            for (int i = 31; i >= 0 && setBits > 0; i--)
            {
                if ((num1 & (1 << i)) > 0)
                {
                    result |= 1 << i;
                    setBits--;
                }
              
            }
            for (int i = 0; i <= 31 && setBits > 0; i++)
            {
                if ((num1 & (1 << i)) == 0)
                {
                    result |= 1 << i;
                    setBits--;
                }
            }
            return result;
        }
        static int GetSetBits(int number)
        {
            int counter = 0;
            while (number > 0)
            {
                counter += number & 1;
                number >>= 1;
            }
            return counter;
        }
    }
}
