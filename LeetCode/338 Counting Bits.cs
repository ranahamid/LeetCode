namespace LeetCode
{
    public class _338_Counting_Bits
    {
        /// <summary>
        /// Runtime: 168 ms, faster than 22.59% of C# online submissions for Counting Bits.
        /// Memory Usage: 38.2 MB, less than 75.73% of C# online submissions for Counting Bits.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int[] CountBits(int n)
        {
            int[] result = new int[n + 1];
            result[0] = 0;
            for (int i = 1; i <= n; i++)
            {
                var m = i;
                var counter = 0;
                while (m>0)
                {
                    counter = counter + (m & 1);
                    m = m >> 1;
                }

                result[i] = counter;
            } 
            return result;
            
        }


    }
}