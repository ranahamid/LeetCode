using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Algo_1
{
    public class Heap
    {
        /// <summary>
        /// https://www.programiz.com/dsa/heap-data-structure
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        /// <param name="i"></param>
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
                Heapify(arr,n, largest);
            }

        }

        public static void MaxHeap(List<int> arr)
        {
            int n= arr.Count;
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(arr,n, i);
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
                for (int i = n / 2 - 1; i >= 0; i--)
                {
                    Heapify(arr,n, i);
                }
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

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(arr,n, i);
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


    }

    #region js
    public class Heap_JS
    {
        /// <summary>
        /// https://www.programiz.com/dsa/heap-data-structure
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="n"></param>
        /// <param name="i"></param>
        public static void BubbleDown(List<int> arr, int i)
        {
            int n = arr.Count;
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
                BubbleDown(arr, largest);
            }
        }

        public static void BuildHeap(List<int> arr)
        {
            int n = arr.Count;
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                BubbleDown(arr, i);
            }
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

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                BubbleDown(arr, i);
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
                for (int i = n / 2 - 1; i >= 0; i--)
                {
                    BubbleDown(arr, i);
                }
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
    #endregion
}
