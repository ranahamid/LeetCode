using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Node_1522
    {
        public int val;
        public IList<Node_1522> children;

        public Node_1522()
        {
            val = 0;
            children = new List<Node_1522>();
        }

        public Node_1522(int _val)
        {
            val = _val;
            children = new List<Node_1522>();
        }

        public Node_1522(int _val, List<Node_1522> _children)
        {
            val = _val;
            children = _children;
        }
    }
    internal class _1522
    {
        /// <summary>
        /// Runtime: 269 ms, faster than 21.05% of C# online submissions for Diameter of N-Ary Tree.
        /// Memory Usage: 47.3 MB, less than 5.26% of C# online submissions for Diameter of N-Ary Tree.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public int Diameter(Node_1522 root)
        {
            if (root == null)
                return 0;
            var max = 0;
            DFS(root, ref max);
            return max;
        }
        public static int DFS(Node_1522 Node_1522, ref int max)
        {
            if (Node_1522 == null)
                return -1;
            List<int> lengths = new List<int>() { 0, 0 };
            foreach (var item in Node_1522.children)
            {
                lengths.Add(DFS(item, ref max));
            }
            lengths.Sort();

            var diameter = lengths.LastOrDefault() + lengths[lengths.Count - 2]; //take maximum 2 number
            max = Math.Max(diameter, max);
            return lengths.LastOrDefault() + 1; //max +1
        }

    }
}
