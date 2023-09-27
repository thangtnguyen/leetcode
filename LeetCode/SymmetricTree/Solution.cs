using CommonDataStructures;

namespace SymmetricTree
{
    /// <summary>
    /// https://leetcode.com/problems/symmetric-tree/
    /// </summary>
    public class Solution
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null) return true;

            return CheckMirror(root.Left, root.Right);
        }

        private bool CheckMirror(TreeNode left, TreeNode right)
        {
            if (left == null && right == null) return true;
            if (left == null || right == null || left.Val != right.Val) return false;

            return CheckMirror(left.Left, right.Right) && CheckMirror(left.Right, right.Left);
        }
    }
}
