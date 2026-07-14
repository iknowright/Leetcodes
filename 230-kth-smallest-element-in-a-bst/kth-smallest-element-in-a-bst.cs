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
    List<int> res=new();
    public int KthSmallest(TreeNode root, int k) {
        Inorder(root);
        return res[k-1];
    }
    public void Inorder(TreeNode root) {
        if(root is null) return;
        Inorder(root.left);
        res.Add(root.val);
        Inorder(root.right);
    }
}