using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2037_Minimum_Number_of_Moves_to_Seat_Everyone
    {
        /// <summary>
        /// Runtime: 154 ms, faster than 21.05% of C# online submissions for Minimum Number of Moves to Seat Everyone.
        /// Memory Usage: 38.7 MB, less than 59.21% of C# online submissions for Minimum Number of Moves to Seat Everyone.
        /// </summary>
        /// <param name="seats"></param>
        /// <param name="students"></param>
        /// <returns></returns>
        public static int MinMovesToSeat(int[] seats, int[] students)
        {
            Array.Sort(seats);
            Array.Sort(students);
            var result = 0;
            for (int i = 0; i < seats.Length; i++)
            {
                result += Math.Abs(seats[i] - students[i]);
            }
            return result;
        }
    }
}
