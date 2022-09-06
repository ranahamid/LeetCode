using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class BSTIterator
    {
        /// <summary>
        /// Runtime: 218 ms, faster than 66.40% of C# online submissions for Binary Search Tree Iterator.
        /// Memory Usage: 50.3 MB, less than 22.31% of C# online submissions for Binary Search Tree Iterator.
        /// </summary>
        List<int> sortedNumbers = new List<int>();
        int index;
        public BSTIterator(TreeNode root)
        {
            List<int> sortedNumbers = new List<int>();
            index = -1;
            InOrder(root);
        }
        public void InOrder(TreeNode root)
        {
            if (root == null)
                return;
            InOrder(root.left);
            sortedNumbers.Add(root.val);
            InOrder(root.right);
        }

        public int Next()
        {
            return sortedNumbers[++index];
        } 
        public bool HasNext()
        {
            return index + 1 < sortedNumbers.Count();
        }
    }
}
