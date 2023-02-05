using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    class _2540
	{
		public int GetCommon(int[] nums1, int[] nums2)
		{
			var len1 = nums1.Length;
			var len2 = nums2.Length;
			int i = 0, j = 0;
			while (i < len1 && j < len2)
			{
				if (nums1[i] == nums2[j])
					return nums1[i];
				if (nums1[i] < nums2[j])
					i++;
				else if (nums1[i] > nums2[j])
					j++;
			}
			return -1;
		}
	}
}
