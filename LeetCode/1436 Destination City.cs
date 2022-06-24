﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1436_Destination_City
    {
        /// <summary>
        /// Runtime: 234 ms, faster than 6.17% of C# online submissions for Destination City.
        /// Memory Usage: 40.7 MB, less than 20.99% of C# online submissions for Destination City.
        /// </summary>
        /// <param name="paths"></param>
        /// <returns></returns>
        public static string DestCity(IList<IList<string>> paths)
        {
            var result = "";
            var path = paths.FirstOrDefault();

            while (result == "")
            {
                paths.Remove(path);
                var pathFound = path.LastOrDefault();
                var isFound = false;
                foreach (var item in paths)
                {
                    var data = item.Where(x => x == pathFound).FirstOrDefault();
                    if (data != null)
                    {
                        path = item;
                        isFound = true;
                        break;
                    }
                }
                if (!isFound)
                {
                    result = pathFound;
                }
            }
            return result;
        }
    }
}