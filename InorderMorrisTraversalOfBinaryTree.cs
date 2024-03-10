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
    public IList<int> InorderTraversal(TreeNode root) {
        TreeNode current = root;
        while(current!=null)
        {
            if(current.left==null)
            {
                resultList.Add(current.val);
                current = current.right;
            }
            else
            {
                TreeNode previous = current.left;
                while(previous.right!=null && previous.right!=current)
                {
                    previous = previous.right;
                }
                if(previous.right == null)
                {
                    previous.right = current;
                    current = current.left;
                }
                else
                {
                    previous.right = null;
                    resultList.Add(current.val);
                    current = current.right;
                }
            }   
        }
        return resultList;
    }  
}