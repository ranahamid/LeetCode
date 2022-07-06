using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// Runtime: 456 ms, faster than 46.63% of C# online submissions for Design HashMap.
    /// Memory Usage: 67.8 MB, less than 13.19% of C# online submissions for Design HashMap.
    /// </summary>
    public class MyHashMap
    {
        private int[] arr;

        public MyHashMap()
        {
            arr = new int[1000001];
            for(int i=0;i<arr.Length; i++)
            {
                arr[i] = -1;
            }
        }

        public void Put(int key, int value)
        {
            arr[key] = value;
        }

        public int Get(int key)
        {
            return arr[key];
        }

        public void Remove(int key)
        {
            arr[key] = -1;
        }
    }

}
