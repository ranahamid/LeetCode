using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode 
{
	public class TreeNode
	{
		public int val;
		public TreeNode left;
		public TreeNode right;
		public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
		{
			this.val = val;
			this.left = left;
			this.right = right;
		}
	}

	public class Solution
	{
		private TreeNode root = null;
		public TreeNode LevelOrder(int?[] array)
		{
			if (array.Count() == 0 || array[0] == null)
				return null;
			int i = 0;
			if (root == null)
            {
				if (array[i] != null)
					root = new TreeNode((int)array[i]);
				i++;
				if (array.Length == i)
					return root;
            }

			var queue = new Queue<TreeNode>();
			queue.Enqueue(root);
            while (queue.Count() > 0)
            {
				var currentItem = queue.Dequeue();
                if (currentItem.left == null)
                {
                    if (array[i] != null)
                    {
						currentItem.left = new TreeNode((int)array[i]);

					}
					i++;
					if (i == array.Length)
						return root;
                    if (currentItem.left != null)
                    {
						queue.Enqueue(currentItem.left);
                    }
                }
                if (currentItem.right == null)
                {
					if (array[i] != null)
                    {
						currentItem.right = new TreeNode( (int)array[i]);

					}
					i++;
					if (i == array.Length)
						return root;
                    if (currentItem.right != null)
                    {
						queue.Enqueue(currentItem.right);
                    }
                }
            }
			return root;
		}
	}
}
