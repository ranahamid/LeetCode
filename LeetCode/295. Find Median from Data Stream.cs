using LeetCode.Algo_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _295
    {
        public class MedianFinder
        {
            PriorityQueue<int, int> low;
            PriorityQueue<int, int> high;
            public MedianFinder()
            {
                // A max-heap to store the smaller half of the input numbers
                // A min-heap to store the larger half of the input numbers
                low = new PriorityQueue<int, int>();
                high = new PriorityQueue<int, int>();
            }
            public void AddNum(int num)
            {
                //The max-heap contains all the smaller numbers while the min-heap contains all the larger numbers
                low.Enqueue(num, num);
                var lowVal = low.Dequeue();
                high.Enqueue(lowVal, -lowVal);

                if (low.Count < high.Count)
                {
                    var highVal = high.Dequeue();
                    low.Enqueue(highVal, highVal);
                }
            }

            public double FindMedian()
            {
                if (low.Count > high.Count)
                    return low.Peek();
                else
                    return (low.Peek() + high.Peek()) / 2.0;
            }
        }
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
