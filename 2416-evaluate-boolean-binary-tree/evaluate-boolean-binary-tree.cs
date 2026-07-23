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
    public bool EvaluateTree(TreeNode root) => root.val switch {
        0 => false,
        1 => true,
        2 => EvaluateTree(root.left) || EvaluateTree(root.right),
        3 => EvaluateTree(root.left) && EvaluateTree(root.right),
        _ => false
    };
}