/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public List<IList<int>> res=new();
    public IList<IList<int>> LevelOrder(Node root) {
        Dfs(root, 0);
        return res;
    }

    public void Dfs(Node node, int depth) {
        if(node is null) return;
        else if(res.Count == depth) res.Add(new List<int>());

        res[depth].Add(node.val);
        if(node.children is not null) {
            foreach(Node child in node.children) Dfs(child, depth+1);
        }
    }
}