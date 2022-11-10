using System;
using System.Collections.Generic;

namespace LeetCode.Z
{
    public class _32__Longest_Valid_Parentheses
    {
        /// <summary>
        /// Runtime: 66 ms, faster than 94.48% of C# online submissions for Longest Valid Parentheses.
        /// Memory Usage: 37.8 MB, less than 6.69% of C# online submissions for Longest Valid Parentheses.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int LongestValidParentheses(string s)
        {
            var st = new Stack<int>();
            st.Push(-1);
            int ans = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                    st.Push(i);
                else
                {
                    st.Pop();
                    if (st.Count == 0)
                    {
                        st.Push(i);
                    }

                    ans = Math.Max(ans, i - st.Peek());
                }
            }
            return ans;
        }



    }
}