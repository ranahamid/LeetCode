using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _875
    {

        #region TLE
        public int MinEatingSpeed_TLE(int[] piles, int h)
        {

            int speed = 1;
            while (true)
            {
                int hour = 0;
                foreach (var item in piles)
                {

                    hour += (int)(Math.Ceiling((double)item / (double)speed));
                    if (hour > h)
                    {
                        break;
                    }
                }

                if (hour <= h)
                {
                    return speed;
                }
                else
                {
                    speed++;
                }
            }
        }
        #endregion
    }
}
