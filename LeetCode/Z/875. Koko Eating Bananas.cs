using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _875
    {
        public int MinEatingSpeed(int[] piles, int h)
        {
            int left = 1;
            int right = piles.Max();
            int speed = 1;
            while (left < right)
            {
                int middle = left + (right - left) / 2;

                int hour = 0;
                foreach (var item in piles)
                {

                    hour += (int)(Math.Ceiling((double)item / (double)middle));
                    if (hour > h)
                    {
                        break;
                    }
                }

                if (hour <= h)
                {
                    right = middle;
                }
                else
                {
                    left = middle + 1;
                }
            }
            return right;
        }
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
