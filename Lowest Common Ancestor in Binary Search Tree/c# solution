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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if (root == null || p == null || q == null)   return null;

        if (root.val >= Math.Min(p.val, q.val) && root.val <= Math.Max(p.val,q.val)) return root;

        if (Math.Max(p.val, q.val) < root.val)  return LowestCommonAncestor(root.left, p, q);
        else return LowestCommonAncestor(root.right, p, q);

        return root;
    }
}
