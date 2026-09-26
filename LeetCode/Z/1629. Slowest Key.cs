using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
	public char SlowestKey(int[] releaseTimes, string keysPressed)
	{
		var lenght = releaseTimes.Length;
		char charResult = keysPressed[0];
		var maxTime = 0;
		for (int i = 0; i < lenght; i++)
		{
			var time = i == 0 ? releaseTimes[i] : releaseTimes[i] - releaseTimes[i - 1];
			if (time >= maxTime)
			{
				if (time == maxTime && charResult > keysPressed[i])
				{
					continue;
				}

				maxTime = time;
				charResult = keysPressed[i];
			}
		}
		return charResult;
	}
}
