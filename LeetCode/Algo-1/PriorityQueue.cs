using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algo_1
{
    public class PriorityQueue
    {
        public static void Display()
        {
            var arr3 = new List<int> { };
            PriorityQueue.Insert(arr3, 3);
            PriorityQueue.Insert(arr3, 4);
            PriorityQueue.Insert(arr3, 9);
            PriorityQueue.Insert(arr3, 5);
            PriorityQueue.Insert(arr3, 2);
            PriorityQueue.Insert(arr3, 6);

            PriorityQueue.PrintHeap(arr3);
            PriorityQueue.Delete(arr3, 6);
            PriorityQueue.PrintHeap(arr3);
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
        public static void Insert(List<int> arr, int number)
        {
            var n = arr.Count;
            if (n == 0)
                arr.Add(number);
            else
            {
                arr.Add(number);
                n = arr.Count;
                MaxHeap(arr);
            }
        }
        public static void Delete(List<int> arr, int number)
        {
            var n = arr.Count;
            int j;
            for (j = 0; j < n; j++)
            {
                if (arr[j] == number)
                {
                    break;
                }
            }
            (arr[j], arr[n - 1]) = (arr[n - 1], arr[j]);

            arr.RemoveAt(n - 1);
            MaxHeap(arr);
        }
        public static int Peek(List<int> arr)
        {
            return arr[0];
        }
        public static int ExtractMax(List<int> arr)
        {
            var maxVal = arr[0];
            Delete(arr, maxVal);
            return maxVal;
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
