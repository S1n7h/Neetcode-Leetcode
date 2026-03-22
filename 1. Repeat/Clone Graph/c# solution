/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> neighbors;

    public Node() {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val) {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors) {
        val = _val;
        neighbors = _neighbors;
    }
}
*/

public class Solution {
    public Node CloneGraph(Node node) {
        var dict = new Dictionary<Node, Node>();
        return Dfs(node, dict);
    }

    Node Dfs(Node node, Dictionary<Node, Node> dict){
        if (node == null)   return null;

        if (dict.ContainsKey(node)) return dict[node];

        Node copy = new Node(node.val);
        dict[node] = copy;

        foreach(var neighbor in node.neighbors){
            copy.neighbors.Add(Dfs(neighbor, dict));
        }
        return copy;
    }
}
