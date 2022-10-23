﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_85
{
    internal class _2380
    {
        public int SecondsToRemoveOccurrences(string s)
        {
            var count = 0;
            while (s.Contains("01"))
            {
                var answer = new char[s.Length];
                for (int j = 0; j < s.Length; j++)
                {
                    answer[j] = s[j];
                }
                int i = 0;
                while (i < answer.Length - 1)
                {
                    if (s[i].ToString() + s[i + 1].ToString() == "01")
                    {
                        answer[i] = '1';
                        answer[i + 1] = '0';
                        i += 2;
                    }
                    else
                    {
                        i++;
                    }
                }
                count++;
                s = new string(answer);
            }
            return count;
        }
    }
}
