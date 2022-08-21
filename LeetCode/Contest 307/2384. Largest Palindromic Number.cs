using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_307
{
    class _2384
	{
		/// <summary>
		/// TLE
		/// </summary>
		/// <param name="num"></param>
		/// <returns></returns>
		public string LargestPalindromic_TLE(string num)
		{
			var answer = new int[10];
			for (int i = 0; i < num.Length; i++)
			{
				int index = num[i] - '0';
				answer[index] += 1;
			}
			string result = "";
			for (int i = 9; i >= 0; i--)
			{
				if (answer[i] != 0)
				{
					if (answer[i] > 1)
					{
						if (answer[i] % 2 == 0)
						{
							int x = answer[i] / 2;
							char y = (char)('0' + i);
							while (x-- > 0)
							{
								result += y;
							}
							answer[i] = 0;
						}
						else
						{
							int x = answer[i] - 1;
							answer[i] = 1;
							x /= 2;
							char y = (char)('0' + i);
							while (x-- > 0)
							{
								result += y;
							}
						}
					}
				}
			}
			bool isAdded = false;
			for (int i = 9; i >= 0; i--)
			{
				char y = (char)('0' + i);
				if (answer[i] == 1)
				{
					result += y;
					isAdded = true;
					break;
				}
			}
			string temp;
			if (isAdded == false)
			{
				temp = result;
				var rev = new string(temp.Reverse().ToArray());
				result = result + rev;
			}
			else
			{
				temp = result;
				//temp.pop_back();
				var s = temp.Substring(0, temp.Length - 1);
				var rev = new string(s.Reverse().ToArray());
				result = result + rev;
			}
			int count = 0;
			for (int i = 0; i < result.Length; i++)
			{
				if (result[i] == '0')
				{
					count++;
				}
				else
				{
					break;
				}
			}

			if (count > 0)
			{
				int te = count;
				while (te-- > 0)
				{
					result = result.Substring(0, result.Length - 1);
				} 
				te = count;
				if (result.Length > 0)
					result = result.Substring(count, result.Length - count); 
			}
			if (result.Length == 0)
				return "0";
			return result;
		}
	}
}
