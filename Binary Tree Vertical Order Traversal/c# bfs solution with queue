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
    public List<List<int>> VerticalOrder(TreeNode root) {
        if (root == null)   return new List<List<int>>();
        var ret = new List<List<int>>();
        var dict = new SortedDictionary<int, List<int>>();

        var q = new Queue<(TreeNode, int)>();
        q.Enqueue((root, 0));

        while(q.Count() != 0){
            int Size = q.Count();

            for (int i = 0 ; i < Size ; i++){
                var top = q.Dequeue();

                if (!dict.ContainsKey(top.Item2)){
                    dict[top.Item2] = new List<int>();
                }dict[top.Item2].Add(top.Item1.val);


                if (top.Item1.left != null)  q.Enqueue((top.Item1.left, top.Item2 - 1));
                if (top.Item1.right != null)  q.Enqueue((top.Item1.right, top.Item2 + 1));
            }
        }

        foreach(var item in dict.Values){
            ret.Add(item);
        }

        return ret;
    }

    
}