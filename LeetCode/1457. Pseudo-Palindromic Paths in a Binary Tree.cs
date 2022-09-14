using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1457
    {
        /// <summary>
        /// Runtime: 325 ms, faster than 100.00% of C# online submissions for Pseudo-Palindromic Paths in a Binary Tree.
        /// Memory Usage: 66.6 MB, less than 33.33% of C# online submissions for Pseudo-Palindromic Paths in a Binary Tree.
        /// </summary>
        int answer = 0;
        public int PseudoPalindromicPaths(TreeNode root)
        {
            PreOrder(root, 0);
            return answer;
        }

        public void PreOrder(TreeNode root, int path)
        {
            if (root == null)
                return;
            path = path ^ (1 << root.val); 
            if (root.left == null && root.right == null)
            {
                if ((path & (path - 1)) == 0)
                    answer++;
            }
            PreOrder(root.left, path);
            PreOrder(root.right, path);
        }
        #region Method 1
        /// <summary>
        /// Runtime: 373 ms, faster than 100.00% of C# online submissions for Pseudo-Palindromic Paths in a Binary Tree.
        /// Memory Usage: 67.3 MB, less than 33.33% of C# online submissions for Pseudo-Palindromic Paths in a Binary Tree.
        /// </summary>
        int res = 0;
        Dictionary<int, int> dic = new Dictionary<int, int>();
        public int PseudoPalindromicPaths_1(TreeNode root)
        {
            VisitPreOrder(root);
            return res;
        }

        public void VisitPreOrder(TreeNode root)
        {
            if (root == null)
                return;
            dic.TryAdd(root.val, 0);
            dic[root.val]++;
            if (root.left == null && root.right == null)
            {
                var noOfOdd = 0;
                foreach (var it in dic)
                {
                    if (it.Value % 2 == 1)
                        noOfOdd++;
                }
                if (noOfOdd <= 1)
                    res++;
            }
            VisitPreOrder(root.left);
            VisitPreOrder(root.right); 
            dic[root.val]--; 
        } 
        #endregion
        #region TLE & Accepted
        int result = 0;
        public int PseudoPalindromicPaths_TLE3(TreeNode root)
        {
            VisitNode(root, new HashSet<int>());
            return result;
        }

        public void VisitNode(TreeNode root, HashSet<int> currentPath)
        {
            if (root == null)
                return;
            if (currentPath.Contains(root.val))
                currentPath.Remove(root.val);
            else
                currentPath.Add(root.val);

            if (root.left == null && root.right == null)
            {
                result += currentPath.Count() <= 1 ? 1 : 0;
            }
            VisitNode(root.left, new HashSet<int>(currentPath));
            VisitNode(root.right, new HashSet<int>(currentPath));
        }
        #endregion
        #region TLE
        int counterRes = 0;
        public int PseudoPalindromicPaths_TLE2(TreeNode root)
        {
            VisitTreeNode(root, new HashSet<int>());
            return counterRes;
        }

        public void VisitTreeNode(TreeNode root, HashSet<int> currentPath)
        {
            if (root == null)
                return;
            if (currentPath.Contains(root.val))
                currentPath.Remove(root.val);
            else
                currentPath.Add(root.val);

            if (root.left == null && root.right == null)
            {
                if (currentPath.Count() <= 1)
                    counterRes++;
            }
            VisitTreeNode(root.left, new HashSet<int>(currentPath));
            VisitTreeNode(root.right, new HashSet<int>(currentPath));
        }
        #endregion
        #region TLE
        int counter = 0;
        public int PseudoPalindromicPaths_TLE(TreeNode root)
        {
            VisitTree(root, new List<int>());
            return counter;
        }

        public void VisitTree(TreeNode root, List<int> currentPath)
        {
            if (root == null)
                return;
            currentPath.Add(root.val);
            if (root.left == null && root.right == null)
            {
                var dic = new Dictionary<int, int>();
                foreach (var item in currentPath)
                {
                    dic.TryAdd(item, 0);
                    dic[item]++;
                }
                var noOfOdd = 0;
                foreach (var it in dic)
                {
                    if (it.Value % 2 == 1)
                        noOfOdd++;
                }
                if (noOfOdd <= 1)
                    counter++;
            }
            VisitTree(root.left, currentPath);
            VisitTree(root.right, currentPath);

            currentPath.RemoveAt(currentPath.Count - 1);
        }
        #endregion
        #region Out of Memory
        List<List<int>> AllPaths = new List<List<int>>();
        public int PseudoPalindromicPaths_Memory(TreeNode root)
        {
            Visit(root, new List<int>(), AllPaths);
            return GetCounter(AllPaths);
        }
        public int GetCounter(List<List<int>> AllPaths)
        {
            int counter = 0;

            foreach (var path in AllPaths)
            {
                var dic = new Dictionary<int, int>();
                foreach (var item in path)
                {
                    dic.TryAdd(item, 0);
                    dic[item]++;
                }
                var noOfOdd = 0;
                foreach (var it in dic)
                {
                    if (it.Value % 2 == 1)
                        noOfOdd++;
                }
                if (noOfOdd <= 1)
                    counter++;
            }
            return counter;
        }
        public void Visit(TreeNode root, List<int> currentPath, List<List<int>> AllPaths)
        {
            if (root == null)
                return;
            currentPath.Add(root.val);
            if (root.left == null && root.right == null)
            {
                var list = currentPath.GetRange(0, currentPath.Count);
                AllPaths.Add(list);
            }
            Visit(root.left, currentPath, AllPaths);
            Visit(root.right, currentPath, AllPaths);

            currentPath.RemoveAt(currentPath.Count - 1);
        }
        #endregion
    }
}
