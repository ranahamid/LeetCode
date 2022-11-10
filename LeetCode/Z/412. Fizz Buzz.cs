using System.Collections.Generic;

namespace LeetCode.Z
{
    public class _412__Fizz_Buzz
    {



        /// <summary>
        /// Runtime: 214 ms, faster than 38.78% of C# online submissions for Fizz Buzz.
        /// Memory Usage: 47.2 MB, less than 33.81% of C# online submissions for Fizz Buzz.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public List<string> FizzBuzz(int n)
        {
            List<string> result = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    result.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    result.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    result.Add("Buzz");
                }
                else
                {
                    result.Add(i.ToString());
                }
            }
            return result;
        }

    }
}