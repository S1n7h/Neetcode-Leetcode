/**
 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     TreeNode *left;
 *     TreeNode *right;
 *     TreeNode() : val(0), left(nullptr), right(nullptr) {}
 *     TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
 *     TreeNode(int x, TreeNode *left, TreeNode *right) : val(x), left(left), right(right) {}
 * };
 */

class Solution {
private:
    int preIndex = 0;
    TreeNode* traversal(vector<int>& preorder, vector<int>& inorder, int begin, int end){
        if (end < begin)    return nullptr;
        
        TreeNode* root = new TreeNode(preorder[preIndex++]);

        int i = begin; 
        while (inorder[i] != root->val && i <= end) i++;

        TreeNode* tleft = traversal(preorder, inorder, begin, i - 1);
        TreeNode* tright = traversal(preorder, inorder, i + 1, end);

        if (tleft) root->left = tleft;
        if (tright) root->right = tright;

        return root;
    }
public:
    TreeNode* buildTree(vector<int>& preorder, vector<int>& inorder) {
        return traversal(preorder, inorder, 0, preorder.size() - 1);
    }
};
