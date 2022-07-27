using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _953
    {
        public bool IsAlienSorted(string[] words, string order)
        {
            var dic = new Dictionary<char, int>();
            var counter = 0;
            foreach (var ch in order)
            {
                dic[ch] = counter++;
            }
            for (int i = 0; i < words.Length - 1; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    if (j >= words[i + 1].Length)
                        return false;

                    var currentOder = words[i][j];
                    var nextOrder = words[i + 1][j];
                    if (currentOder != nextOrder)
                    {
                        if (dic[currentOder] > dic[nextOrder])
                        {
                            return false;
                        }
                        else
                        {
                            break;
                        }
                    }

                }
            }
            return true;
        }
    }
}
