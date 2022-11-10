using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1720_Decode_XORed_Array
    {
        /// <summary>
        /// Runtime: 241 ms, faster than 48.28% of C# online submissions for Decode XORed Array.
        /// Memory Usage: 47.1 MB, less than 51.72% of C# online submissions for Decode XORed Array.
        /// </summary>
        /// <param name="encoded"></param>
        /// <param name="first"></param>
        /// <returns></returns>

        public static int[] Decode(int[] encoded, int first)
        {
            int[] decoded = new int[encoded.Length + 1];
            decoded[0] = first;
            //Console.WriteLine(decoded[0]);
            for (int i = 0; i < encoded.Length; i++)
            {
                decoded[i + 1] = Math.Abs(encoded[i] ^ decoded[i]);
                Console.WriteLine(decoded[i + 1]);
            }

            return decoded;
        }
    }
}
