namespace LeetCode
{
    public class _1822__Sign_of_the_Product_of_an_Array 
    {
        
        public static int ArraySign(int[] nums) {
        
            
            int negetiveCount = 0;
            foreach(var item in nums)
            {
                if(item==0)
                    return 0;
                if (item < 0)
                    negetiveCount++;
            }

            if (negetiveCount % 2 == 0)
                return 1;
            else
            {
                return -1;
            }
            
        }
    }
}