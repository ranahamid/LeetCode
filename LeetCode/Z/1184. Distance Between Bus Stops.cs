using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1184
    {
        /// <summary>
        /// Runtime: 143 ms, faster than 21.62% of C# online submissions for Distance Between Bus Stops.
        /// Memory Usage: 38 MB, less than 37.84% of C# online submissions for Distance Between Bus Stops.
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="start"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public int DistanceBetweenBusStops(int[] distance, int start, int destination)
        {
            int clockwise = 0, antiClockwise = 0;
            if (start > destination)
                (start, destination) = (destination, start);
            for (int i = 0; i < distance.Length; i++)
            {
                if (i >= start && i < destination)
                {
                    clockwise += distance[i];
                }
                else
                {
                    antiClockwise += distance[i];
                }
            }
            return Math.Min(clockwise, antiClockwise);
        }
        /// <summary>
        /// Runtime: 108 ms, faster than 67.57% of C# online submissions for Distance Between Bus Stops.
        /// Memory Usage: 38 MB, less than 37.84% of C# online submissions for Distance Between Bus Stops.
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="start"></param>
        /// <param name="destination"></param>
        /// <returns></returns>
        public int DistanceBetweenBusStops_2(int[] distance, int start, int destination)
        {
            var clockWise = 0;
            var counerClockWise = 0;
            //clock wise
            if (destination >= start)
            {
                for (int i = start; i < destination; i++)
                {
                    clockWise += distance[i];
                }
            }
            else
            {
                for (int i = start; i < distance.Length; i++)
                {
                    clockWise += distance[i];
                }
                for (int i = 0; i < destination; i++)
                {
                    clockWise += distance[i];
                }
            }
            //counerClockWise
            if (destination >= start)
            {
                for (int i = start - 1; i >= 0; i--)
                {
                    counerClockWise += distance[i];
                }
                for (int i = distance.Length - 1; i >= destination; i--)
                {
                    counerClockWise += distance[i];
                }
            }
            else
            {
                for (int i = start - 1; i >= destination; i--)
                {
                    counerClockWise += distance[i];
                }
            }
            return Math.Min(counerClockWise, clockWise);
        }
    }
}
