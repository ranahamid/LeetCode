using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    internal class _346
    {
        class MovingAverage
        {
            private int[] array;
            private int index = 0;

            public MovingAverage(int size)
            {
                array = new int[size];
                for (int i = 0; i < size; i++)
                {
                    array[i] = Int32.MinValue;
                }
            }

            public double Next(int val)
            {
                array[index++] = val;
                if (index >= array.Length)
                {
                    index = 0;
                }
                int counter = 0;
                double sum = 0;
                for (int i = 0; i < array.Count(); i++)
                {
                    if (array[i] != Int32.MinValue)
                    {
                        sum += array[i];
                        counter++;
                    }
                }
                return sum / (double)counter;

            }
        }
    }
}
