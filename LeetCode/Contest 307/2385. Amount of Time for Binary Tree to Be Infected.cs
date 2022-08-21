using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_307
{
    internal class _2385
    {
        public static int FindBurningAmount(TreeNode root, int num, Dictionary<int, HashSet<int>> answerSet)
        {
            if (root != null)
            {
                if (root.val == num)
                {
                    StoreTheNumbers(root.left, 1, answerSet);
                    StoreTheNumbers(root.right, 1, answerSet);
                    return 1;
                }
                int k = FindBurningAmount(root.left, num, answerSet);
                if (k > 0)
                {
                    SaveData(root, k, answerSet);
                    StoreTheNumbers(root.right, k + 1, answerSet);
                    return k + 1;
                }
                k = FindBurningAmount(root.right, num, answerSet);
                if (k > 0)
                {
                    SaveData(root, k, answerSet);
                    StoreTheNumbers(root.left, k + 1, answerSet);
                    return k + 1;
                }
            }
            return -1;
        }
        public static void StoreTheNumbers(TreeNode root, int k, Dictionary<int, HashSet<int>> answerSet)
        {
            if (root != null)
            {
                SaveData(root, k, answerSet);
                StoreTheNumbers(root.left, k + 1, answerSet);
                StoreTheNumbers(root.right, k + 1, answerSet);
            }
        }
        private static void SaveData(TreeNode root, int k, Dictionary<int, HashSet<int>> answerSet)
        {
            if (answerSet.ContainsKey(k))
            {
                answerSet[k].Add(root.val);
            }
            else
            {
                HashSet<int> dataSet = new HashSet<int>();
                dataSet.Add(root.val);
                answerSet.Add(k, dataSet);
            }
        }
        static Dictionary<TreeNode, List<TreeNode>> map = new Dictionary<TreeNode, List<TreeNode>>();
        public int AmountOfTime(TreeNode root, int start)
        {
            Dictionary<int, HashSet<int>> answerSet = new Dictionary<int, HashSet<int>>();
            FindBurningAmount(root, start, answerSet);
            return answerSet.Count;
        }
    }
}
