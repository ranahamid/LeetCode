using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2582
    {
        public int PassThePillow(int n, int time)
        {

            var result = 1;
            var direction = 1;

            for (int i = 0; i < time; i++)
            {
                if (direction == 1)
                    result++;
                if (direction == -1)
                    result--;

                if (result == n)
                    direction = -1;
                if (result == 1)
                    direction = 1;
            }
            return result;
        }
    }
}
