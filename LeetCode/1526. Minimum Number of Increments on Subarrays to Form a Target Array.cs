namespace LeetCode
{
    public class _1526__Minimum_Number_of_Increments_on_Subarrays_to_Form_a_Target_Array 
    { 
        /// <summary>
        /// Runtime: 270 ms, faster than 58.33% of C# online submissions for Minimum Number of Increments on Subarrays to Form a Target Array.
        /// Memory Usage: 47 MB, less than 66.67% of C# online submissions for Minimum Number of Increments on Subarrays to Form a Target Array.
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        public static int MinNumberOperations(int[] target)
        {
            var ans = 0;
            var currentVal = 0;
            foreach (var value in target)
            {
                if (value > currentVal)
                {
                    ans = ans + (value - currentVal);
                }

                currentVal = value;
            }
            return ans;
        }


    }
}