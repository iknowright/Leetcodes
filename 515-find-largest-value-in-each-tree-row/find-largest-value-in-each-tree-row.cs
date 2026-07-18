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
    public IList<int> LargestValues(TreeNode root) {
        Dfs(root, 0);
        return res.ToArray();
    }
    public void Dfs(TreeNode root, int level) {
        if(root is null) return;
        if(res.Count==level) res.Add(root.val);
        else res[level] = Math.Max(res[level], root.val);
        Dfs(root.left, level+1);
        Dfs(root.right, level+1);
    }
}