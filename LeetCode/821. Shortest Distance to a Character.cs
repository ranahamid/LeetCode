using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _821__Shortest_Distance_to_a_Character {
            
        /// <summary>
        /// Runtime: 146 ms, faster than 79.63% of C# online submissions for Shortest Distance to a Character.
        /// Memory Usage: 43.4 MB, less than 12.96% of C# online submissions for Shortest Distance to a Character.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static int[] ShortestToChar(string s, char c)
        {
            var sChars = s.ToCharArray();
            int[] result = new int[sChars.Length];
            var lengthArray = new List<int>();
            for(int i=0;i<sChars.Length;i++)
            {
                if(sChars[i]==c)
                    lengthArray.Add(i);   
            }

            for (int i = 0; i < sChars.Length; i++)
            {
                if (sChars[i] == c)
                    result[i] = 0;
                else
                {
                    var minimum = GetMinimum(i, lengthArray);
                    result[i] = minimum;
                }
            }

            return result;
        }
        public static int GetMinimum(int i,List<int> lengthArray)
        {
            var min = Int32.MaxValue;
            foreach (var num in lengthArray)
            {
                var val = Math.Abs(num - i);
                min = Math.Min(min, val);
            }

            return min;
        }


    }
}