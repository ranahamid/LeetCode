namespace LeetCode
{
    public class _657_Robot_Return_to_Origin
    {
        /// <summary>
        /// Runtime: 123 ms, faster than 36.88% of C# online submissions for Robot Return to Origin.
        /// Memory Usage: 38.8 MB, less than 73.76% of C# online submissions for Robot Return to Origin.
        /// </summary>
        /// <param name="moves"></param>
        /// <returns></returns>
        public static bool JudgeCircle(string moves)
        {
            var chars = moves.ToCharArray();
            int left = 0, right = 0, up = 0, down = 0;
            for (int i = 0; i < moves.Length; i++)
            {
                if (chars[i] == 'U')
                {
                    up++;
                }
                else if (chars[i] == 'D')
                {
                    down++;
                }
                else if (chars[i] == 'L')
                {
                    left++;
                }
                else if (chars[i] == 'R')
                {
                    right++;
                }
            }

            if (left == right && down == up)
                return true;
            return false;
        }
    }
}