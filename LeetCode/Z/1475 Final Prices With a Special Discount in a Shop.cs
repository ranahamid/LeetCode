namespace LeetCode.Z
{
    /// <summary>
    /// Runtime: 244 ms, faster than 15.58% of C# online submissions for Final Prices With a Special Discount in a Shop.
    /// Memory Usage: 42.4 MB, less than 27.27% of C# online submissions for Final Prices With a Special Discount in a Shop.
    /// </summary>
    public class _1475_Final_Prices_With_a_Special_Discount_in_a_Shop
    {
        public static int[] FinalPrices(int[] prices)
        {
            var len = prices.Length;
            for (int i = 0; i < len; i++)
            {
                for (int j = i + 1; j < len; j++)
                {
                    if (prices[j] <= prices[i])
                    {
                        prices[i] = prices[i] - prices[j];
                        break;
                    }
                }
            }
            return prices;
        }
    }
}