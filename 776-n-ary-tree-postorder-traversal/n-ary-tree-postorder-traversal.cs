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
    List<int> res=new();
    public IList<int> Postorder(Node root) {
        Traversal(root);
        return res;
    }
    public void Traversal(Node root) {
        if(root is null) return;
        foreach(Node child in root.children) Traversal(child);
        res.Add(root.val);
    }
}