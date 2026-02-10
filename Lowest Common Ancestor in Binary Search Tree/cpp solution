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

public:
    TreeNode* lowestCommonAncestor(TreeNode* root, TreeNode* p, TreeNode* q) {
            while(root){
                if (p->val < q->val){
                    if (p->val <= root->val && q->val >= root->val) return root;
                    else if (root->left == nullptr)  root = root->right;
                    else if (root->right == nullptr)  root = root->left;
                    else if (p->val > root->val) root = root->right;
                    else if (q->val < root->val)  root = root->left;  
                }else{
                    if (p->val >= root->val && q->val <= root->val) return root;
                    else if (root->left == nullptr)  root = root->right;
                    else if (root->right == nullptr)  root = root->left;
                    else if (p->val < root->val) root = root->left;
                    else if (q->val > root->val)  root = root->right; 
                }              
            }return root;
    }
};
