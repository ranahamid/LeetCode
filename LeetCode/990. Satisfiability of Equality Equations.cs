using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _990
    {
        /// <summary>
        /// Runtime: 146 ms, faster than 51.52% of C# online submissions for Satisfiability of Equality Equations.
      ///  Memory Usage: 39.8 MB, less than 39.39% of C# online submissions for Satisfiability of Equality Equations.
      /// </summary>
      /// <param name="parent"></param>
      /// <param name="x"></param>
      /// <returns></returns>
            public int FindParent(int[] parent, int x)
            {
                if (x == parent[x])
                    return x;
                return FindParent(parent, parent[x]);
            }
            public bool EquationsPossible(string[] equations)
            {
                int[] parent = new int[26];
                for (int i = 0; i < 26; i++)
                    parent[i] = i;
                foreach (var eq in equations)
                {
                    if (eq[1] == '=')
                    {
                        int x = eq[0] - 'a';
                        int y = eq[3] - 'a';
                        parent[FindParent(parent, x)] = FindParent(parent, y);
                    }
                }
                foreach (var eq in equations)
                {
                    if (eq[1] == '!')
                    {
                        int x = eq[0] - 'a';
                        int y = eq[3] - 'a';
                        if (FindParent(parent, y) == FindParent(parent, x))
                            return false;
                    }
                }
                return true;
            }
     
    }
}
