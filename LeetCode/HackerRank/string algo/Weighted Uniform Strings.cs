using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.string_algo
{
    internal class Weighted_Uniform_Strings
    {
        public static List<string> weightedUniformStrings(string s, List<int> queries)
        {
            var result = new List<int>();
            char prev = '1';
            int mul = 1;
            for (int i = 0; i < s.Length; i++)
            {
                int w = s[i] - 'a' + 1;
                if (s[i] == prev)
                {
                    mul++;
                    w *= mul;
                }
                else
                {
                    mul = 1;
                }
                prev = s[i];
                result.Add(w);
            }
            var output = new List<string>();
            for (int i = 0; i < queries.Count; i++)
            {
                if (result.Contains(queries[i]))
                {
                    output.Add("Yes");
                }
                else
                {
                    output.Add("No");
                }
            }
            return output;
        }


        /// <summary>
        /// TLE
        /// </summary>
        /// <param name="s"></param>
        /// <param name="queries"></param>
        /// <returns></returns>

        public static List<string> weightedUniformStrings_TLE(string s, List<int> queries)
        {
            var result = new List<int>();
            for (int i = 0; i < s.Length; i++)
            {
                result.Add(s[i] - 'a' + 1);
                if (i + 1 < s.Length && s[i] == s[i + 1])
                {
                    var counter = i;
                    StringBuilder sb = new StringBuilder();
                    sb.Append(s[counter]);
                    while (counter + 1 < s.Length && s[counter] == s[counter + 1])
                    {
                        sb.Append(s[counter]);
                        var sum = 0;
                        for (int j = 0; j < sb.Length; j++)
                        {
                            sum += sb[j] - 'a' + 1;
                        }
                        result.Add(sum);
                        counter++;
                    }
                }
            }
            var output = new List<string>();
            for (int i = 0; i < queries.Count; i++)
            {
                if (result.Contains(queries[i]))
                {
                    output.Add("Yes");
                }
                else
                {
                    output.Add("No");
                }
            }
            return output;
        }


    }
}
