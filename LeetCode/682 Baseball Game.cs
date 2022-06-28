using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _682_Baseball_Game
    {
        /// <summary>
        /// Runtime: 151 ms, faster than 21.33% of C# online submissions for Baseball Game.
        /// Memory Usage: 38.4 MB, less than 22.67% of C# online submissions for Baseball Game.
        /// </summary>
        /// <param name="ops"></param>
        /// <returns></returns>
        public static int CalPoints(string[] ops)
        {

            var result = new int[ops.Length];
            var counter = 0;
            for (int i = 0; i < ops.Length; i++)
            {
                if (ops[i] == "C")
                {
                    result[counter - 1] = 0;
                    counter--;
                }
                else if (ops[i] == "D")
                {
                    var number = result[counter - 1] * 2;
                    result[counter++] = number;
                }
                else if (ops[i] == "+")
                {
                    var number = result[counter - 1] + result[counter - 2];
                    result[counter++] = number;
                }
                else
                {
                    if (Int32.TryParse(ops[i], out int number))
                    {
                        result[counter++] = number;
                    }

                }
            }
            var sum = 0;
            for (int i = 0; i < ops.Length; i++)
            {
                sum = sum + result[i];
            }
            return sum;
        }


    }
}
