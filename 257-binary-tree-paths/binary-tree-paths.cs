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
    List<string> res=new();
    public IList<string> BinaryTreePaths(TreeNode root) {
        if (root.left is null && root.right is null) {
            res.Add(root.val.ToString());
            return res;
        }
        Path(root.left, root.val.ToString());
        Path(root.right, root.val.ToString());
        return res;
    }
    public void Path(TreeNode root, string history) {
        if(root is null) return;
        history += "->"+root.val.ToString();
        if(root.left is not null || root.right is not null) {
            Path(root.left, history);
            Path(root.right, history);
        }
        else res.Add(history);
    }
}