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
    public int tilt=0;
    public int FindTilt(TreeNode root) {
        Tilter(root);
        return tilt;
    }
    public int Tilter(TreeNode node) {
        if(node is null) return 0;
        int left = Tilter(node.left); 
        int right = Tilter(node.right);
        tilt += Math.Abs(left- right);
        return node.val + left + right;
    }
}