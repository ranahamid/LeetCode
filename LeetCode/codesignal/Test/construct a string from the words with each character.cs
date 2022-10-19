using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.codesignal.Test
{
    internal class construct_a_string_from_the_words_with_each_character
    {
        string solution(string[] arr)
        {
            StringBuilder sb = new StringBuilder();
            int counter = 0;
            bool isFinished = false;
            while (!isFinished)
            {
                isFinished = true;
                foreach (var item in arr)
                {
                    if (item.Length > counter)
                    {
                        sb.Append(item[counter]);
                        isFinished = false;
                    }
                }
                counter++;
            }
            return sb.ToString();
        }

    }
}
