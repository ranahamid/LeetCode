using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    public class StockPrice
    {
        /// <summary>
        /// Runtime: 825 ms, faster than 94.53% of C# online submissions for Stock Price Fluctuation .
        /// Memory Usage: 129.4 MB, less than 18.75% of C# online submissions for Stock Price Fluctuation .
        /// </summary>
        PriorityQueue<(int, int), int> maxHeap = new PriorityQueue<(int, int), int>();
        PriorityQueue<(int, int), int> minHeap = new PriorityQueue<(int, int), int>();
        Dictionary<int, int> map = new Dictionary<int, int>();
        int latestTime = 0;
        public StockPrice()
        {
            latestTime = 0;
        }

        public void Update(int timestamp, int price)
        {
            latestTime = Math.Max(latestTime, timestamp);
            if (map.ContainsKey(timestamp))
                map[timestamp] = price;
            else
                map.Add(timestamp, price);

            maxHeap.Enqueue((timestamp, price), -price);
            minHeap.Enqueue((timestamp, price), price);
        }

        public int Current()
        {
            return map[latestTime];
        }

        public int Maximum()
        {
            while (map[maxHeap.Peek().Item1] != maxHeap.Peek().Item2)
            {
                maxHeap.Dequeue();
            }
            return maxHeap.Peek().Item2;
        }

        public int Minimum()
        {
            while (map[minHeap.Peek().Item1] != minHeap.Peek().Item2)
            {
                minHeap.Dequeue();
            }
            return minHeap.Peek().Item2;
        }
        #region anothr
        public int Maximum_1()
        {
            var items = maxHeap.Peek();
            while (map[items.Item2] != items.Item1)
            {
                maxHeap.Dequeue();
                items = maxHeap.Peek();
            }
            return items.Item1;
        }

        public int Minimum_1()
        {
            var items = minHeap.Peek();
            while (map[items.Item2] != items.Item1)
            {
                minHeap.Dequeue();
                items = minHeap.Peek();
            }
            return items.Item1;
        }
        #endregion
    }
}
