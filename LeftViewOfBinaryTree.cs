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
    public IList<int> RightSideView(TreeNode root, int level = 0) {
        if(root == null) 
            return resultList;

        if(resultList.Count == level) 
            resultList.Add(root.val);

        RightSideView(root.right, level+1);
        RightSideView(root.left, level+1);

        return resultList;
    }
}