using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.codesignal.Test
{
    internal class zigzag
    {
        int[] solution(int[] numbers)
        {
            var length = numbers.Length;
            var result = new int[length - 2];
            for (int i = 0; i < length - 2; i++)
            {


                if (
                    (numbers[i] < numbers[i + 1] && numbers[i + 1] > numbers[i + 2]) ||
                    (numbers[i] > numbers[i + 1] && numbers[i + 1] < numbers[i + 2])
                )
                {

                    result[i] = 1;
                }



            }
            return result;
        }

    }
}
