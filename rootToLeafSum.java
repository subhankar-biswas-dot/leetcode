class Solution {
    int sum=0;
    public int sumNumbers(TreeNode root) {
        String str = "";
        //int sum=0;
        Util(root,str,0);
        return sum;
    }
    public void Util(TreeNode root,String str,int pathLen){
        if(root==null ) return;
        
        if(pathLen<=str.length()-1) {
            str.toCharArray()[0]=Character.forDigit(root.val,10);
        }
        else {
            str+=Integer.toString(root.val);
            pathLen++;
        }
        if(root.right==null && root.left == null){
            sum+=Integer.valueOf(str);
        }
        else{
            Util(root.left,str,pathLen);
            Util(root.right,str,pathLen);
        }
    }
}