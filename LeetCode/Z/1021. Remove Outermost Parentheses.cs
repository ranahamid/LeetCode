using System.Text;

namespace LeetCode.Z
{
    public class _1021__Remove_Outermost_Parentheses
    {
        /// <summary>
        /// Runtime: 85 ms, faster than 90.91% of C# online submissions for Remove Outermost Parentheses.
        /// Memory Usage: 37.6 MB, less than 47.73% of C# online submissions for Remove Outermost Parentheses.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string RemoveOuterParentheses(string s)
        {
            var counter = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    if (counter > 0)
                    {
                        sb.Append("(");
                    }

                    counter++;
                }
                else if (s[i] == ')')
                {
                    counter--;
                    if (counter > 0)
                    {
                        sb.Append(")");
                    }

                }
            }
            return sb.ToString();
        }
    }
}