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
    public TreeNode? BuildTree(int[] preorder, int[] inorder) {
        if (preorder.Count() == 0)    return null;

        TreeNode root = new TreeNode();
        int idx = 0;
        root.val = preorder[idx];
        for (int i = 0 ; i < inorder.Length ; i++){
            if (inorder[i] == root.val){
                root.left = SplitTree(root.left, preorder, inorder, 0, i - 1,ref idx); 

                root.right = SplitTree(root.right, preorder, inorder, i + 1, inorder.Length - 1,ref idx);
            }
        }return root;
    }

    private TreeNode? SplitTree(TreeNode root, int[] preorder, int[] inorder, int l, int r, ref int idx){
        if (l > r) return null;

        root = new TreeNode();
        root.val = preorder[++idx];
        Console.WriteLine($"{l} - {r} , {idx}");
        for (int i = l ; i <= r ; i++){
            if (preorder[idx] == inorder[i]){
                root.left = SplitTree(root.left, preorder, inorder, l, i - 1, ref idx);
                root.right = SplitTree(root.right, preorder, inorder, i + 1, r, ref idx);

                break;
            }
        }return root;
    }
}