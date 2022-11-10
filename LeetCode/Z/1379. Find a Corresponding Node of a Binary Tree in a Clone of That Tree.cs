namespace LeetCode.Z
{
    public class TreeNode_1379
    {
        public int val;
        public TreeNode_1379 left;
        public TreeNode_1379 right;
        public TreeNode_1379(int x) { val = x; }
    }
    /// <summary>
    /// Runtime: 623 ms, faster than 5.08% of C# online submissions for Find a Corresponding Node of a Binary Tree in a Clone of That Tree.
    /// Memory Usage: 48.8 MB, less than 66.89% of C# online submissions for Find a Corresponding Node of a Binary Tree in a Clone of That Tree.
    /// </summary>
    public class _1379__Find_a_Corresponding_Node_of_a_Binary_Tree_in_a_Clone_of_That_Tree
    {

        public TreeNode_1379 GetTargetCopy(TreeNode_1379 original, TreeNode_1379 cloned, TreeNode_1379 target)
        {
            if (original == null || original == target)
            {
                return cloned;
            }
            var leftPart = GetTargetCopy(original.left, cloned.left, target);

            var rightPart = GetTargetCopy(original.right, cloned.right, target);
            if (leftPart != null)
                return leftPart;
            else
                return rightPart;

        }
    }
}