using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2651
    {
    
            public int FindDelayedArrivalTime(int arrivalTime, int delayedTime)
            {
                return (arrivalTime + delayedTime) % 24;
            }
   
    }
}
