namespace LeetCode.Z
{
    public class _1689_Partitioning_Into_Minimum_Number_Of_Deci_Binary_Numbers
    {
        public static int MinPartitions(string n)
        {
            var chars = n.ToCharArray();
            var maxChar = '0';
            foreach (var item in chars)
            {
                if (item > maxChar)
                    maxChar = item;
            }
            return maxChar - 48;
        }
    }
}