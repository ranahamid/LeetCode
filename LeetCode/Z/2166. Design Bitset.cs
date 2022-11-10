using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    /// <summary>
    /// Runtime: 963 ms, faster than 80.00% of C# online submissions for Design Bitset.
    /// Memory Usage: 120.5 MB, less than 50.00% of C# online submissions for Design Bitset.
    /// </summary>
    public class Bitset
    {
        HashSet<int> one = new HashSet<int>();
        HashSet<int> zero = new HashSet<int>();
        int length = 0;
        public Bitset(int size)
        {
            length = size;
            for (int i = 0; i < length; i++)
            {
                zero.Add(i);
            }
        }

        public void Fix(int idx)
        {
            zero.Remove(idx);
            one.Add(idx);
        }

        public void Unfix(int idx)
        {
            one.Remove(idx);
            zero.Add(idx);
        }

        public void Flip()
        {
            var s = one;
            one = zero;
            zero = s;
        }

        public bool All()
        {
            return length == one.Count();
        }

        public bool One()
        {
            return one.Count() > 0;
        }

        public int Count()
        {
            return one.Count();
        }

        public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                if (one.Contains(i))
                    sb.Append("1");
                else if (zero.Contains(i))
                    sb.Append("0");
            }
            return sb.ToString();
        }
    }
}
