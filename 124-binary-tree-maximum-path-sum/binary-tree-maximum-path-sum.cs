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
    public int max=int.MinValue;
    public int MaxPathSum(TreeNode root) {
        Maximum(root);
        return max;
    }
    public int Maximum(TreeNode root) {
        if(root is null) return 0;
        int left = Math.Max(0, Maximum(root.left));
        int right = Math.Max(0, Maximum(root.right));
        int curr = root.val + left + right;

        max = Math.Max(max, curr);
        return root.val + Math.Max(left, right);
    }
}