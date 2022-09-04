using System;

namespace LeetCode
{
    internal class _987
    {
        /// <summary>
        /// Runtime: 226 ms, faster than 55.56% of C# online submissions for Vertical Order Traversal of a Binary Tree.
        /// Memory Usage: 41.1 MB, less than 92.22% of C# online submissions for Vertical Order Traversal of a Binary Tree.
        /// </summary>
        public class Triplet
        {
            public int Column { get; set; }
            public int Row { get; set; }
            public int Value { get; set; }

        }
        public IList<IList<int>> VerticalTraversal(TreeNode root)
        {
            var result = new List<IList<int>>();
            if (root == null)
                return result;
            var queue = new Queue<(TreeNode node, int row, int column)>();
            //var dic = new SortedDictionary<int, List<int>>();
            var nodeList = new List<Triplet>();
            //BFS
            int row = 0, column = 0;
            queue.Enqueue((root, row, column));
            while (queue.Count > 0)
            {
                var item = queue.Dequeue();
                root = item.node;
                row = item.row;
                column = item.column;

                if (root != null)
                {
                    nodeList.Add(new Triplet
                    {
                        Column = column,
                        Row = row,
                        Value = root.val,
                    });
                    queue.Enqueue((root.left, row + 1, column - 1));
                    queue.Enqueue((root.right, row + 1, column + 1));
                }
            }
            //sort the list 
            //advance sort
            //nodeList.Sort((t1, t2) =>
            //{
            //    //1 priority: column
            //    //2 priority: row
            //    //3 priority: value

            //    if (t1.Column == t2.Column)
            //    {
            //        if (t1.Row == t2.Row)
            //            return t1.Value - t2.Value;
            //        else
            //            return t1.Row - t2.Row;
            //    }
            //    else
            //        return t1.Column - t2.Column;
            //});
            nodeList = nodeList.OrderBy(x => x.Column).ThenBy(x => x.Row).ThenBy(x => x.Value).ToList();

            // step 3). extract the values, partitioned by the column index.
            var currColumnIndex = nodeList.FirstOrDefault()?.Column;
            List<int> currColumn = new List<int>();

            foreach (var triplet in nodeList)
            {
                var col = triplet.Column;
                var val = triplet.Value;

                if (col == currColumnIndex)
                {
                    currColumn.Add(val);
                }
                else
                {
                    result.Add(currColumn);

                    currColumnIndex = col;
                    currColumn = new List<int>();
                    currColumn.Add(val);
                }
            }
            result.Add(currColumn);

            return result;
        }
    }
}
