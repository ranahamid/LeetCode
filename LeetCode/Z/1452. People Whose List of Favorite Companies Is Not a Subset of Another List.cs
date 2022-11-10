using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1452
    {
        /// <summary>
        /// TLE
        /// </summary>
        /// <param name="favoriteCompanies"></param>
        /// <returns></returns>
        public IList<int> PeopleIndexes(IList<IList<string>> favoriteCompanies)
        {
            var result = new List<int>();
            for (int i = 0; i < favoriteCompanies.Count; i++)
            {
                var currentPerson = favoriteCompanies[i];
                var maxCount = 0;
                for (int j = 0; j < favoriteCompanies.Count; j++)
                {
                    if (i == j)
                        continue;
                    var nextPersonList = favoriteCompanies[j];



                    //////////////////

                    var counter = 0;
                    foreach (var item in nextPersonList)
                    {
                        if (currentPerson.Contains(item))
                        {
                            counter++;
                        }
                    }
                    maxCount = Math.Max(maxCount, counter);
                }
                if (currentPerson.Count > maxCount)
                    result.Add(i);
                /////////////
            }
            return result;
        }
    }
}
