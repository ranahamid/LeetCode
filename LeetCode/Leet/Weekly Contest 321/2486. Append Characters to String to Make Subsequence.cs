using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Leet.Weekly_Contest_321
{
    class _2486
	{
		public int AppendCharacters(string s, string t)
		{
			int i = 0;
			foreach (var ch in s)
			{
				if (ch == t[i])
					i++;
				if (t.Length == i)
					break;
			}
			return t.Length - i;
		}
	}
}
