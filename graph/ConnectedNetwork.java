package graph;


public class ConnectedNetwork {
    public static void main(String[] args) {
        int [][] connections={{0,1},{0,2},{3,4},{2,3}};
        findConnections(connections, 5);
    }

    public static void findConnections(int [][] connections,int n){
        int [] parent=new int[n];
        int count =0;
        for(int i=0;i<n;i++)
            parent[i]=i;
        for(int i=0;i<connections.length;i++){
            Union(parent, connections[i][0], connections[i][1]);
        }
        for(int i=0;i<n;i++){
            if(find(parent,parent[i])==i)
                count++;
           
        }
        System.out.println(count-1);
    }
    public static int find(int [] parent,int i){
        if(parent[i]==i)return i;
        return find(parent, parent[i]);
    }
    public static void Union(int [] parent,int x,int y){
        int xset=find(parent, x);
        int yset=find(parent, y);
        parent[xset]=yset;
    }
}
