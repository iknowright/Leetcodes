/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    TreeNode res=null;
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        Ancestor(root, p, q);
        return res;
    }
    public bool Ancestor(TreeNode root, TreeNode p, TreeNode q) {
        if(root is null) return false;

        bool left = Ancestor(root.left, p, q);
        bool right = Ancestor(root.right, p, q);
        if(root==p || root==q) {
            if(left || right) {
                res=root;
            }
            return true;
        }
        else {
            if(left && right) {
                res=root;
                return true;
            }
            return left || right;
        }
    }
}