using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// Runtime: 146 ms, faster than 91.63% of C# online submissions for Design Circular Queue.
    ///Memory Usage: 52.7 MB, less than 11.33% of C# online submissions for Design Circular Queue.
    /// </summary>
    public class MyCircularQueue
    {
        int[] arr;
        int count = 0;
        int capacity = 0;
        int headIndex = 0;
        public MyCircularQueue(int k)
        {
            arr = new int[k];
            capacity = k;
            count = 0;
            headIndex = 0;
        }

        public bool EnQueue(int value)
        {
            if (count < capacity)
            {
                var i = (headIndex + count) % capacity;
                arr[i] = value;
                count++;
                return true;
            }
            return false;
        }

        public bool DeQueue()
        {
            if (count > 0)
            {
                headIndex = (headIndex + 1) % capacity;
                count--;
                return true;
            }
            return false;
        }

        public int Front()
        {
            if (count == 0)
                return -1;
            return arr[headIndex];
        }

        public int Rear()
        {
            if (count == 0)
                return -1;
            var tailIndex = (headIndex + count - 1) % capacity;
            return arr[tailIndex];
        }

        public bool IsEmpty()
        {
            if (count == 0)
                return true;
            return false;
        }

        public bool IsFull()
        {
            if (count == capacity)
                return true;
            return false;
        }
    }
    public class MyCircularQueue_1
    {
        int[] arr;
        int count = 0;
        int capacity = 0;
        int headIndex = 0;
        public MyCircularQueue_1(int k)
        {
            arr = new int[1000000];
            capacity = k;
            count = 0;
            headIndex = 0;
        }

        public bool EnQueue(int value)
        {
            if (count < capacity)
            {
                var i = (headIndex + count);
                arr[i] = value;
                count++;
                return true;
            }
            return false;
        }

        public bool DeQueue()
        {
            if (count > 0)
            {
                headIndex = (headIndex + 1);
                count--;
                return true;
            }
            return false;
        }

        public int Front()
        {
            if (count == 0)
                return -1;
            return arr[headIndex];
        }

        public int Rear()
        {
            if (count == 0)
                return -1;
            var tailIndex = (headIndex + count - 1);
            return arr[tailIndex];
        }

        public bool IsEmpty()
        {
            if (count == 0)
                return true;
            return false;
        }

        public bool IsFull()
        {
            if (count == capacity)
                return true;
            return false;
        }
    }
}
