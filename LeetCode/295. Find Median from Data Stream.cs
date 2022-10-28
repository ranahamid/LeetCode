using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _295
    {
        #region brute Force
        public class MedianFinder_TLE
        {
            List<int> numbers;
            int length;
            public MedianFinder_TLE()
            {
                length = 0;
                numbers = new List<int>();
            }

            public void AddNum(int num)
            {
                numbers.Add(num);
                length++;
            }

            public double FindMedian()
            {
                numbers.Sort();
                if (length % 2 == 1)
                    return numbers[length / 2];//0,1,2
                return (double)(numbers[length / 2 - 1] + numbers[length / 2]) / 2.0;//1,2
            }
        }
        #endregion
    }
}
