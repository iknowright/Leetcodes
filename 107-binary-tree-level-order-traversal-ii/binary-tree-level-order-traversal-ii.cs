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
    public List<IList<int>> res = new();
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
        Dfs(root, 0);
        res.Reverse();
        return res;
    }
    public void Dfs(TreeNode root, int level) {
        if(root is null) return;
        if(res.Count==level) res.Add(new List<int>());
        res[level].Add(root.val);
        Dfs(root.left, level+1);
        Dfs(root.right, level+1);
    }
}