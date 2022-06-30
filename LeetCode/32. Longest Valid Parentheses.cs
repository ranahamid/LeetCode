using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class _32__Longest_Valid_Parentheses {
        /// <summary>
        /// Runtime: 109 ms, faster than 32.80% of C# online submissions for Longest Valid Parentheses.
        /// Memory Usage: 35.3 MB, less than 99.34% of C# online submissions for Longest Valid Parentheses.
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
                if(s[i]=='(')
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