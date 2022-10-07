using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_307
{
    public class TreeNode_307
    {
        public int val;
        public TreeNode_307 left;
        public TreeNode_307 right;
        public TreeNode_307(int val = 0, TreeNode_307 left = null, TreeNode_307 right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    internal class _2385
    {
        #region interview prep
        Dictionary<int, List<int>> graph = new Dictionary<int, List<int>>();
        bool[] visited = new bool[100001];
        int ans = -1;
        void MakeGraph(TreeNode root)
        {
            if (root == null)
                return;
            var list = new List<TreeNode> { root.left, root.right };
            foreach (var item in list)
            {
                if (item != null)
                {
                    graph.TryAdd(item.val, new List<int>());
                    graph.TryAdd(root.val, new List<int>());

                    graph[item.val].Add(root.val);
                    graph[root.val].Add(item.val);
                }
                MakeGraph(item);
            }
        }
        public int AmountOfTime(TreeNode root, int start)
        {
            MakeGraph(root);
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(start);
            while (queue.Count > 0)
            {
                int lenght = queue.Count;
                for (int i = 0; i < lenght; i++)
                {
                    var current = queue.Dequeue();
                    visited[current] = true;
                    if (graph.ContainsKey(current))
                        foreach (var item in graph[current])
                        {
                            if (!visited[item])
                            {
                                queue.Enqueue(item);
                            }
                        }
                }
                ans++;
            }
            return ans;
        }
        #endregion
        /// <summary>
        /// Runtime: 404 ms, faster than 100.00% of C# online submissions for Amount of Time for Binary Tree to Be Infected.
        /// Memory Usage: 85 MB, less than 100.00% of C# online submissions for Amount of Time for Binary Tree to Be Infected.
        /// </summary>
        /// <param name="root"></param>
        /// <param name="num"></param>
        /// <param name="answerSet"></param>
        /// <returns></returns>
        public static int FindBurningAmount(TreeNode_307 root, int num, Dictionary<int, HashSet<int>> answerSet)
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
        public static void StoreTheNumbers(TreeNode_307 root, int k, Dictionary<int, HashSet<int>> answerSet)
        {
            if (root != null)
            {
                SaveData(root, k, answerSet);
                StoreTheNumbers(root.left, k + 1, answerSet);
                StoreTheNumbers(root.right, k + 1, answerSet);
            }
        }
        private static void SaveData(TreeNode_307 root, int k, Dictionary<int, HashSet<int>> answerSet)
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
        static Dictionary<TreeNode_307, List<TreeNode_307>> map = new Dictionary<TreeNode_307, List<TreeNode_307>>();
        public int AmountOfTime(TreeNode_307 root, int start)
        {
            Dictionary<int, HashSet<int>> answerSet = new Dictionary<int, HashSet<int>>();
            FindBurningAmount(root, start, answerSet);
            return answerSet.Count;
        }
    }
}
