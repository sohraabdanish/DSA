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
    List<int> resultList = new();
    public IList<int> PreorderTraversal(TreeNode root) {
        PreorderTraverse(root);
        return resultList;
    }

    public void PreorderTraverse(TreeNode root){
        if(root==null)
            return;
        
        PreorderTraverse(root.left);
        PreorderTraverse(root.right);
        resultList.Add(root.val);
    }
}