using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    #region self
    public class Codec_5
    {
        public StringBuilder RecursiveSerialize(TreeNode root, StringBuilder sb)
        {
            if (root == null)
            {
                sb.Append("null,");
                return sb;
            }
            sb.Append(root.val);
            sb.Append(",");
            RecursiveSerialize(root.left, sb);
            RecursiveSerialize(root.right, sb);
            return sb;
        }
        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            StringBuilder sb = RecursiveSerialize(root, new StringBuilder());
            return sb.ToString();
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            var words = data.Split(',', StringSplitOptions.RemoveEmptyEntries);

            return RecDeserialize(words.ToList());
        }
        public TreeNode RecDeserialize(List<string> words)
        {
            var word = words.FirstOrDefault();
            if (word == "null")
            {
                words.RemoveAt(0);
                return null;
            }
            var root = new TreeNode(Int32.Parse(word));
            words.RemoveAt(0);
            root.left = RecDeserialize(words);
            root.right = RecDeserialize(words);
            return root;
        }
    }
    #endregion
    public class Codec_4
    {
        /// <summary>
        /// Runtime: 170 ms, faster than 48.98% of C# online submissions for Serialize and Deserialize Binary Tree.
        /// Memory Usage: 46.4 MB, less than 25.32% of C# online submissions for Serialize and Deserialize Binary Tree.
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>

        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            var serText = RecSerialize(root, new StringBuilder());
            Console.WriteLine(serText);
            return serText.ToString();
        }
        public StringBuilder RecSerialize(TreeNode root, StringBuilder sb)
        {
            if (root == null)
            {
                sb.Append("null,");
            }
            else
            {
                sb.Append(root.val + ",");
                RecSerialize(root.left, sb);
                RecSerialize(root.right, sb);
            }
            return sb;
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            var words = data.Split(',', StringSplitOptions.RemoveEmptyEntries);
            return RecursiveDeserialize(words.ToList());
        }
        public TreeNode RecursiveDeserialize(List<string> dataList)
        {
            var word = dataList.FirstOrDefault();
            if (word == "null")
            {
                dataList.RemoveAt(0);
                return null;
            }
            TreeNode root = new TreeNode(Int32.Parse(word));
            dataList.RemoveAt(0);

            root.left = RecursiveDeserialize(dataList);
            root.right = RecursiveDeserialize(dataList);
            return root;
        }

    }
}
