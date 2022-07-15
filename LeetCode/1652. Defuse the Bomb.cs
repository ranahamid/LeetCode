using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1652
    {
        /// <summary>
        /// Runtime: 210 ms, faster than 50.00% of C# online submissions for Defuse the Bomb.
        /// Memory Usage: 43.6 MB, less than 6.25% of C# online submissions for Defuse the Bomb.
        /// </summary>
        /// <param name="code"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int[] Decrypt(int[] code, int k)
        {
            if (k == 0)
            {
                for (int i = 0; i < code.Length; i++)
                {
                    code[i] = 0;
                }
                return code;
            }
            var result = new int[code.Length];
            for (int i = 0; i < code.Length; i++)
            {
                var element = new List<int>();
                if (k > 0)
                {
                    element = NextElement(i, code.Length - 1, k);
                }
                else
                {
                    element = PreviousElement(i, code.Length - 1, Math.Abs(k));//previous
                }
                var sum = 0;
                foreach (var item in element)
                {
                    sum += code[item];
                }
                result[i] = sum;
            }
            return result;
        }
        public static List<int> NextElement(int currentPosition, int lastElement, int k)
        {
            var element = new List<int>();
            for (int i = 0; i < k; i++)
            {
                currentPosition++;
                if (currentPosition > lastElement)
                {
                    currentPosition = 0;
                }
                element.Add(currentPosition);
            }
            return element;
        }
        public static List<int> PreviousElement(int currentPosition, int lastElement, int k)
        {
            var element = new List<int>();
            for (int i = 0; i < k; i++)
            {
                currentPosition--;
                if (currentPosition < 0)
                {
                    currentPosition = lastElement;
                }
                element.Add(currentPosition);
            }
            return element;
        }


    }
}
