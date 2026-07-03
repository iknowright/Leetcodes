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
    public int SumOfLeftLeaves(TreeNode root) {
        return Sum(root, false);
    }
    public int Sum(TreeNode root, bool left) {
        if(root is null) return 0;
        if(root.left is null && root.right is null) {
            return left? root.val:0;
        }
        return Sum(root.left, true)+Sum(root.right, false);
    }
}