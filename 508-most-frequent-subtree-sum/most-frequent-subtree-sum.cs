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
    public int max=0;
    public Dictionary<int, int> counts=new();
    public int[] FindFrequentTreeSum(TreeNode root) {
        Sum(root);
        List<int> res=new();
        foreach(var kvp in counts) {
            if(kvp.Value==max) res.Add(kvp.Key);
        }
        return res.ToArray();
    }
    public int Sum(TreeNode root) {
        if(root is null) return 0;
        int left=Sum(root.left), right=Sum(root.right);
        int curr = root.val+left+right;
        counts[curr] = counts.GetValueOrDefault(curr)+1;
        max = Math.Max(counts[curr], max);
        return curr;
    }
}