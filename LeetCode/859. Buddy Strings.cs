using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _859
    {
        #region count 2
        public bool BuddyStrings(string s, string goal)
        {
            if (s.Length != goal.Length)
                return false;

            var freqS = GetFrequencyString(s);
            var freqG = GetFrequencyString(goal);
            foreach (var item in freqS)
            {
                if (freqG.ContainsKey(item.Key))
                {
                    var goalVal = freqG[item.Key];
                    if (goalVal != item.Value)
                        return false;
                }
                else
                {
                    return false;
                }

            }
            if (s.Equals(goal))
            {

                foreach (var item in freqS)
                {
                    if (item.Value > 1)
                        return true;
                }
                return false;
            }
            else
            {
                var count = 0;
                for (int i = 0; i < goal.Length; i++)
                {
                    if (goal[i] != s[i])
                        count++;
                }
                if (count > 2)
                    return false;
                return true;
            }
        }
        public static Dictionary<char, int> GetFrequencyString(string s)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (map.ContainsKey(s[i]))
                {
                    map[s[i]]++;
                }
                else
                {
                    map[s[i]] = 1;
                }
            }
            return map;
        }
        #endregion
        #region  buddy Count 1
        public bool BuddyStrings_2(string s, string goal)
        {
            if (s.Length != goal.Length)
                return false;


            if (s.Equals(goal))
            {
                var freqS = GetFrequencyString(s);
                foreach (var item in freqS)
                {
                    if (item.Value > 1)
                        return true;
                }
                return false;
            }
            else
            {
                var first = -1;
                var second = -1;
                for (int i = 0; i < goal.Length; i++)
                {
                    if (goal[i] != s[i])
                    {
                        if (first == -1)
                        {
                            first = i;
                        }
                        else if (second == -1)
                        {
                            second = i;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                if (second != -1 && s[first] == goal[second] && s[second] == goal[first])
                    return true;
                else
                    return false;
            }
        }
    
        #endregion


    }
}
