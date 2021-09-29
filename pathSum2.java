class Solution {
    List<List<Integer>> res = new ArrayList<List<Integer>>();
    public List<List<Integer>> pathSum(TreeNode root, int targetSum) {
        
        int [] array = new int[5000];
        int pathLen =0;
        Util(root,targetSum,array,0);
        return res;
    }
    public void Util(TreeNode root,int targetSum,int [] path,int pathLen){
        if(root==null) return ;
        path[pathLen++] = root.val;
        targetSum-=root.val;
        if(targetSum==0 && root.right == null && root.left == null){
            List<Integer> li = Arrays.stream(path,0,pathLen).boxed().collect(Collectors.toList());
            res.add(li);
        }
        else{
            Util(root.left,targetSum,path,pathLen);
            Util(root.right,targetSum,path,pathLen);
        }
    }
}