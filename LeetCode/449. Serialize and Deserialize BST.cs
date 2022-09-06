using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class Codec_2
    {
        public StringBuilder PostOrder(TreeNode root, StringBuilder sb)
        {
            if (root == null)
                return sb;
            PostOrder(root.left, sb);
            PostOrder(root.right, sb);
            sb.Append(root.val);
            sb.Append(' ');
            return sb;
        }

        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            var sb = PostOrder(root, new StringBuilder());
            if (sb.Length > 0)
                sb.Remove(sb.Length - 1, 1);
            
            return sb.ToString();
        }
        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            if (string.IsNullOrEmpty(data))
                return null;
            var list = new List<int>();
            var words = data.Split(' ', options: StringSplitOptions.RemoveEmptyEntries);
            foreach (var w in words)
                list.Add(int.Parse(w));
            return BuildTree(list);
        }
        public TreeNode BuildTree(List<int> list, int minValue = Int32.MinValue, int maxValue = Int32.MaxValue)
        {
            if (list.Count == 0)
                return null;
            var num = list.LastOrDefault();
            if (!(num > minValue && num < maxValue))
                return null;


            list.RemoveAt(list.Count - 1);

            TreeNode root = new TreeNode(num);
            root.right = BuildTree(list, num, maxValue);
            root.left = BuildTree(list, minValue, num);

            return root;
        }
    }

    public class Codec_1
    {

        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            string json = JsonConvert.SerializeObject(root);
            return json;
        }
        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            var user = JsonConvert.DeserializeObject<TreeNode>(data);
            return user;
        }
    }
}
