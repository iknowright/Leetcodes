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
    public TreeNode DeleteNode(TreeNode root, int key) {
        if(root is null) return root;
        else if(root.val > key) root.left = DeleteNode(root.left, key);
        else if(root.val < key) root.right = DeleteNode(root.right, key);
        else {
            if(root.left is null && root.right is null) return null;
            else if(root.left is null) return root.right;
            else if(root.right is null) return root.left;
            else {
                root.val = Min(root.right);
                root.right = DeleteNode(root.right, root.val);
            }
        }
        return root;
    }

    public int Min(TreeNode node) {
        while(node.left is not null) node = node.left;
        return node.val;
    }
}