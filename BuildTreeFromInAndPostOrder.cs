public class Solution {
    Dictionary<int,int> dict = new Dictionary<int,int>();
    int postOrder;
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
        int len = inorder.Length;
        for(int i=0;i<len;i++){
            dict.Add(inorder[i],i);
        }
        postOrder=len-1;
        return BuildTreeUtil(inorder,postorder,0,len-1);
    }
    public TreeNode BuildTreeUtil(int [] In,int [] Post,int start,int end ){
        if(start>end) return null;
        int curr = Post[postOrder--];
        TreeNode temp = new TreeNode(curr);
        if(start==end) return temp;
        int mid = dict[curr];
        temp.right=BuildTreeUtil(In,Post,mid+1,end);
        temp.left = BuildTreeUtil(In,Post,start,mid-1);
        return temp;
    }
}