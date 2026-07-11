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
    public int RangeSumBST(TreeNode root, int low, int high) {
        if(root is null) return 0;
        return ((root.val >=low && root.val <=high)? root.val : 0) + RangeSumBST(root.left, low, high) + RangeSumBST(root.right, low, high);
    }
}