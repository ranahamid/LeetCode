using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    internal class _1826
    {
        /// <summary>
        /// Runtime 141 ms Beats 100%
        /// </summary>
        /// <param name="sensor1"></param>
        /// <param name="sensor2"></param>
        /// <returns></returns>
        public int BadSensor(int[] sensor1, int[] sensor2)
        {
            var len = sensor1.Length;
            int i = 0;
            while (i < len && sensor1[i] == sensor2[i])
                i++;
            while (i + 1 < len && sensor1[i + 1] == sensor2[i] && sensor1[i] == sensor2[i + 1])
                i++;
            if (i >= len - 1)
                return -1;
            if (sensor1[i] == sensor2[i + 1])
                return 1;
            return 2;
        }
    }
}
