namespace LeetCode
{
    public class _1716__Calculate_Money_in_Leetcode_Bank {
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