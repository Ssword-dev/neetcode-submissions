/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public int MaxDepth(TreeNode root, int currentDepth = 0) {
        if (root is null) return currentDepth;
        return Math.Max(MaxDepth(root.left, currentDepth+1), MaxDepth(root.right, currentDepth+1));
    }
}
