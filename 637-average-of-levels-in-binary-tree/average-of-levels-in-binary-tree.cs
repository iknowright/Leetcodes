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
    List<double> res = [];
    List<List<long>> counts = [];
    public IList<double> AverageOfLevels(TreeNode root) {
        Dfs(root, 0);
        foreach(List<long> count in counts) {
            res.Add(count.Sum()/(double)count.Count);
        }
        return res;
    }

    public void Dfs(TreeNode node, int depth) {
        if(node is null) return;
        else if(counts.Count == depth) counts.Add(new List<long>());

        counts[depth].Add(node.val);

        Dfs(node.left, depth+1); Dfs(node.right, depth+1); 
    }
}