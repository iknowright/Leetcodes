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
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        List<int> leaf1=[], leaf2=[];
        GetLeaf(root1, leaf1); GetLeaf(root2, leaf2);
        
        if(leaf1.Count != leaf2.Count) return false;

        for(int i=0; i<leaf1.Count; i++) {
            if(leaf1[i] != leaf2[i]) return false;
        }
        return true;
    }

    public void GetLeaf(TreeNode node, List<int> list) {
        if(node is null) return;
        else if(node.left is null && node.right is null) list.Add(node.val);
        else { GetLeaf(node.left, list); GetLeaf(node.right, list); }
    }
}