class Solution {
    public Node connect(Node root) {
        if(root==null) return root;
        Queue<Node> q = new LinkedList<>();
        var dup = root;
        q.add(root);
        q.add(null);
        while(!q.isEmpty()){
            var temp=q.poll();
            if(temp!=null){
                if(temp.left!=null){
                  q.add(temp.left);
                } 
                if(temp.right!=null) {
                    q.add(temp.right);
                }
                if(temp!=root){
                    if(dup==null){
                        dup=temp;
                    }else{
                        dup.next = temp;
                        dup=temp;
                    }
                }
                    
            }
            else{
                if(!q.isEmpty()) {
                    q.add(null);
                    dup=null;
                }
            }
        }
        return root;
    }
}