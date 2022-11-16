using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2469
    {
        /// <summary>
        /// Runtime 154 ms Beats 55.87% Memory 34.6 MB Beats 91.6%
        /// </summary>
        /// <param name="celsius"></param>
        /// <returns></returns>
        public double[] ConvertTemperature(double celsius)
        { 
            var result = new double[2];
            result[0] = celsius + 273.15;
            result[1] = celsius * 1.8 + 32;
            return result;
        }
    }
}
