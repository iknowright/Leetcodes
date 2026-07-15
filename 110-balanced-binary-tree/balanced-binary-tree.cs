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
    public bool IsBalanced(TreeNode root) {
        return Height(root) !=-1;
    }

    public int Height(TreeNode root) {
        if(root is null) return 0;
        if(root.left==null && root.right==null) return 1;
        int left = Height(root.left), right=Height(root.right);
        if(left==-1 || right==-1) return -1;
        if(Math.Abs(left-right)>1) return -1;
        return Math.Max(left, right)+1;
    }
}