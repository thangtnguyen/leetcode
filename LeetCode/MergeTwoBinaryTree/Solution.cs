using CommonDataStructures;

namespace MergeTwoBinaryTree
{
    internal class Solution
    {
        public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null) return null;
            if (root1 == null) return root2;
            if (root2 == null) return root1;

            TreeNode mergedTree = new TreeNode(root1.Val + root2.Val);
            mergedTree.Left = MergeTrees(root1.Left, root2.Left);
            mergedTree.Right = MergeTrees(root1.Right, root2.Right);

            return mergedTree;
        }
    }
}
