using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.string_algo
{
    internal class Grading_Students
    {
        public static List<int> gradingStudents(List<int> grades)
        {
            var result = new List<int>();
            foreach (var item in grades)
            {
                if (item >= 38)
                {
                    var nextElement = item;
                    while (nextElement % 5 != 0)
                    {
                        nextElement++;
                    }
                    var diff = nextElement - item;
                    if (diff < 3)
                    {
                        result.Add(nextElement);
                    }
                    else
                    {
                        result.Add(item);
                    }
                }
                else
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}
