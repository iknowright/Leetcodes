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
    public int sum=0;
    public TreeNode BstToGst(TreeNode root) {
        Traverse(root);
        return root;
    }

    public void Traverse(TreeNode node) {
        if(node is null) return;
        Traverse(node.right);
        sum+= node.val;
        node.val=sum;
        Traverse(node.left);
    }
}