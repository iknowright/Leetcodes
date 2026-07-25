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
    Dictionary <int, List<(int row, int value)>> map=new();
    public IList<IList<int>> VerticalTraversal(TreeNode root) {
        Dfs(root, 0, 0);

        List<IList<int>> res=new(); 
        List<int> sorted=new();
        foreach(var column in map.Keys.OrderBy(c => c)) {
            sorted = map[column].OrderBy(node => node.row).ThenBy(node => node.value).Select(node => node.value).ToList();
            res.Add(sorted);
        }
        return res;
    }
    public void Dfs(TreeNode node, int row, int column) {
        if(node is null) return;
        if(!map.ContainsKey(column)) {
            map[column] = new List<(int row, int column)>();
        }
        map[column].Add((row, node.val));

        Dfs(node.left, row+1, column-1);
        Dfs(node.right, row+1, column+1);
    }
}