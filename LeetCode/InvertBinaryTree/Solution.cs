using CommonDataStructures;

namespace InvertBinaryTree
{
    /// <summary>
    /// https://leetcode.com/problems/invert-binary-tree/
    /// </summary>
    public class Solution
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null) return null;

            TreeNode temp = root.Left;
            root.Left = root.Right;
            root.Right = temp;

            InvertTree(root.Left);
            InvertTree(root.Right);

            return root;
        }
    }
}
