using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_307
{
    internal class _2383
    {
        /// <summary>
        /// Runtime: 105 ms, faster than 100.00% of C# online submissions for Minimum Hours of Training to Win a Competition.
        /// Memory Usage: 37.8 MB, less than 100.00% of C# online submissions for Minimum Hours of Training to Win a Competition.
        /// </summary>
        /// <param name="initialEnergy"></param>
        /// <param name="initialExperience"></param>
        /// <param name="energy"></param>
        /// <param name="experience"></param>
        /// <returns></returns>
        public int MinNumberOfHours(int initialEnergy, int initialExperience, int[] energy, int[] experience)
        {
            var result = 0;
            for (int index = 0; index < energy.Length; index++)
            {
                if (initialEnergy <= energy[index])
                {
                    var minVal = energy[index] + 1 - initialEnergy;
                    result += minVal;
                    initialEnergy += minVal;
                }
                initialEnergy -= energy[index];
                if (initialExperience <= experience[index])
                {
                    var minVal = experience[index] + 1 - initialExperience;
                    result += minVal;
                    initialExperience += minVal;
                }
                initialExperience += experience[index];
            }
            return result;
        }
    }
}
