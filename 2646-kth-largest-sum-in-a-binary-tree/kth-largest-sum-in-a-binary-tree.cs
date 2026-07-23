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
    public List<long> levels=new();
    public long KthLargestLevelSum(TreeNode root, int k) {
        Dfs(root, 0);
        if(levels.Count<k) return -1;
        levels.Sort();
        return levels[levels.Count-k];
    }
    public void Dfs(TreeNode root, int level) {
        if(root is null) return;
        else if(levels.Count==level) levels.Add(root.val);
        else levels[level] +=root.val;

        Dfs(root.left, level+1);
        Dfs(root.right, level+1);
    }
}