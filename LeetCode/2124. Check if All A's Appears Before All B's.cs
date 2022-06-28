namespace LeetCode
{
    /// <summary>
    /// Runtime: 96 ms, faster than 50.00% of C# online submissions for Check if All A's Appears Before All B's.
    /// Memory Usage: 36.5 MB, less than 94.44% of C# online submissions for Check if All A's Appears Before All B's.
    /// </summary>
    public class _2124__Check_if_All_A_s_Appears_Before_All_B_s 
    {
        public static  bool CheckString(string s)
        {
            var chars = s.ToCharArray();
            var isBappeared = false;
            for (int i = 0; i < s.Length; i++)
            {
                if (chars[i] == 'b')
                {
                    isBappeared = true;
                }
                else if (chars[i] == 'a' && isBappeared)
                {
                    return false;
                }
            }

            return true;
        }
    }
}