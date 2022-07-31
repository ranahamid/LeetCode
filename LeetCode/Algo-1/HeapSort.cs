using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algo_1
{
    
    /// <summary>
    /// https://www.programiz.com/dsa/heap-sort#heap
    /// </summary>
    public class HeapSort
    {
        public static void Display()
        {
            var arr3 = new List<int> { 1, 12, 9, 5, 6, 10 };
            HeapSort.Sort(arr3);
            HeapSort.PrintHeap(arr3);
        }
        public static void Sort(List<int> arr)
        {
            int n = arr.Count;
            MaxHeap(arr);
            //sort         
            for (int i = n - 1; i >= 0; i--)
            {
                (arr[i], arr[0]) = (arr[0], arr[i]);
                Heapify(arr, i, 0);
            }
        }
        public static void Heapify(List<int> arr, int n, int i)
        {
            var largest = i;
            var leftChild = 2 * i + 1;
            var rightChild = 2 * i + 2;

            if (leftChild < n && arr[leftChild] > arr[largest])
            {
                largest = leftChild;
            }
            if (rightChild < n && arr[rightChild] > arr[largest])
            {
                largest = rightChild;
            }
            if (largest != i)
            {
                (arr[largest], arr[i]) = (arr[i], arr[largest]);
                Heapify(arr, n, largest);
            }

        }
        public static void MaxHeap(List<int> arr)
        {
            int n= arr.Count;
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(arr, n, i);
            }
        }

        public static void PrintHeap(List<int> arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }


    }
}
