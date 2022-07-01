using System;

namespace LeetCode
{
    public class _1710__Maximum_Units_on_a_Truck {
        public static int MaximumUnits(int[][] boxTypes, int truckSize)
        {
            int result = 0;
            Array.Sort(boxTypes,(a ,b)=> b[1].CompareTo(a[1]));
            var minLen = 0;
            for (int i = 0; i < boxTypes.Length; i++)
            {
                minLen = Math.Min(truckSize, boxTypes[i][0]);
                truckSize = truckSize - minLen;
                result = result + (minLen * boxTypes[i][1]);
            }
            return result;
        }
    }
}