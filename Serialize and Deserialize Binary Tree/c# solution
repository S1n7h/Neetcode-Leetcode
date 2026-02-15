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

public class Codec {

    // Encodes a tree to a single string.
    public string Serialize(TreeNode root) {
        if (root == null)   return "n,";
        var q = new Queue<TreeNode>();
        var ret = "";
        q.Enqueue(root);

        while(q.Count() != 0){
            int Size = q.Count();
            
            for (int i = 0 ; i < Size ; i++){
                var top = q.Dequeue();

                // Console.WriteLine($"{top.val}");

                if (top == null) {
                    ret += "n,";
                    continue;
                }
                else ret += Convert.ToString(top.val) + ',';

                q.Enqueue(top.left);
                q.Enqueue(top.right);
            }ret += '#';
        }Console.WriteLine($"{ret}");
        return ret;
    }

    // Decodes your encoded data to tree.
    public TreeNode Deserialize(string data) {
        if (data[0] == 'n') return null;

        var nodeList = new List<TreeNode>();
        var q = new Queue<int>();
        var root = new TreeNode();

        int temp = 0;

        for (int i = 0 ; i < data.Length ; i++){
            if (data[i] == '#'){
                if (nodeList.Count == 0){
                    int top = q.Dequeue();
                    root.val = top;
                    nodeList.Add(root);
                }
                else{
                    int remove = 0;
                    int Size = nodeList.Count();
                    for (int j = 0 ; j < Size ; j++){                        
                        remove++;
                        int leftNum = q.Dequeue();
                        int rightNum = q.Dequeue();

                        if (leftNum == -1001)  nodeList[j].left = null;
                        else {
                            nodeList[j].left = new TreeNode(leftNum);
                            nodeList.Add(nodeList[j].left);
                        }

                        if (rightNum == -1001)  nodeList[j].right = null;
                        else {
                            nodeList[j].right = new TreeNode(rightNum);
                            nodeList.Add(nodeList[j].right);
                        }
                    }nodeList.RemoveRange(0, remove);
                }
            }
            else if (data[i] == ','){
                q.Enqueue(temp);
                temp = 0;
            }else if (data[i] == 'n'){
                temp = -1001;
            }
            else{
                temp = temp * 10 + (data[i] - '0');
            }
        }return root;
    }
}
