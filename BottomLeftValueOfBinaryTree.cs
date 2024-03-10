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
    public List<int> FindBottomLeftValueBT(TreeNode root, int level = 0) {
        if(root == null)
            return resultList;
        
        if (resultList.Count == level)
            resultList.Add(root.val);

        FindBottomLeftValueBT(root.left, level+1);
        FindBottomLeftValueBT(root.right, level+1);

        return resultList;
    }

    public int FindBottomLeftValue(TreeNode root)
    {
        return FindBottomLeftValueBT(root).Last();
    }
}