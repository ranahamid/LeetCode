using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algo_1
{
    internal class Valid_Heap
    {
        public static void Display()
        {
            int[] arr33 = { 9, 7, 3, 6, 0, 3, 2, 4 };
            if (isHeap(arr33, 0))
            {
                Console.Write("Yes");
            }
            else
            {
                Console.Write("No");
            }
        } 
        static bool isHeap(int[] arr, int i)
        {
            int n = arr.Length - 1;
            // If (2 * i) + 1 >= n, then leaf node, so return true
            if (i >= (n - 1) / 2)
            {
                return true;
            }
            // If an internal node and is greater than its children, and same is recursively true for the children
            if (arr[i] >= arr[2 * i + 1] && arr[i] >= arr[2 * i + 2] &&
                isHeap(arr, 2 * i + 1) && isHeap(arr, 2 * i + 2))
            {
                return true;
            }
            return false;
        }
    }
}
