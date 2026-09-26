using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2660
    {
        public int IsWinner(int[] player1, int[] player2)
        {
            var len = player1.Length;
            var p1 = GetScore(player1);
            var p2 = GetScore(player2);
            if (p1 == p2)
                return 0;
            if (p1 > p2)
                return 1;
            return 2;
        }
        public int GetScore(int[] scores)
        {
            var len = scores.Length;
            var result = 0;
            var prev1 = -1;
            var prev2 = -1;
            for (int i = 0; i < len; i++)
            {
                if (prev1 == 10 || prev2 == 10)
                {
                    result = result + scores[i] * 2;
                }
                else
                {
                    result = result + scores[i];
                }
                prev2 = prev1;
                prev1 = scores[i];
            }
            return result;
        }
    }
}
