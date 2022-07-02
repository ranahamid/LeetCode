namespace LeetCode
{
    public class _1716__Calculate_Money_in_Leetcode_Bank {

        /// <summary>
        /// Runtime: 29 ms, faster than 77.78% of C# online submissions for Calculate Money in Leetcode Bank.
        /// Memory Usage: 26.6 MB, less than 15.56% of C# online submissions for Calculate Money in Leetcode Bank.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int TotalMoney(int n)
        {
            if(n<=7)
                return n * (n + 1) / 2;
            else
            {
                var firstSeven=  28;
                var weeks = n / 7;
                var remaining = n - weeks * 7;
                int sum = 0;
                for (int i = 0; i < weeks; i++)
                {
                    sum = sum + (i * 7 + firstSeven);
                }

                for (int j = weeks + 1; j < weeks + 1 + remaining; j++)
                {
                    sum = sum + j;
                }

                return sum;
            }
        }


    }
}