using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _129
    {
        /// <summary>
        /// Runtime: 180 ms, faster than 5.45% of C# online submissions for Sum Root to Leaf Numbers.
        /// Memory Usage: 37.9 MB, less than 13.86% of C# online submissions for Sum Root to Leaf Numbers.
        /// </summary>
        int sum = 0;
        public int SumNumbers(TreeNode root)
        {
            Traverse(root, new int[1000]);
            return sum;
        }
        public void Traverse(TreeNode root, int[] tempList, int lenght = 0)
        {
            if (root == null)
            {
                return;
            }
            tempList[lenght] = root.val;
            lenght++;
            if (root.left == null && root.right == null)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var item in tempList.Take(lenght))
                {
                    sb.Append(item);
                }
                sum += int.Parse(sb.ToString());
            }
            else
            {
                Traverse(root.left, tempList, lenght);
                Traverse(root.right, tempList, lenght);
            }

        }
    }
}
