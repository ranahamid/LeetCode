using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    public class BSTIterator_II
    {
        List<int> sortedNumbers = new List<int>();
        int index;
        public BSTIterator_II(TreeNode root)
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

        public bool HasPrev()
        {
            Console.WriteLine(index - 1);
            return index - 1 >= 0 && index - 1 < sortedNumbers.Count();
        }

        public int Prev()
        {
            return sortedNumbers[--index];
        }
    }
}
