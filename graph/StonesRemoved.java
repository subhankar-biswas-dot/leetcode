package graph;

import java.util.HashSet;

public class StonesRemoved {
    public static void main(String[] args) {
        int [][] stones = {{2,6},{2,0},{4,2},{1,0},{5,2},{0,2},{6,5}};
        int n=stones.length;
        int [] parent = new int [20000];
        for(int i=0;i<20000;i++){
            parent[i]=i;
        }
        for(int [] stone:stones){
            Union(parent, stone[0], stone[1]+10000);
        }
        HashSet<Integer> set = new HashSet<>();
        for(int [] stone:stones){
            set.add(find(parent,stone[0]));
        }
        System.out.print(n-set.size());
    }
    public static int find(int [] parent,int i){
        if(parent[i]==i)return i;
        return find(parent, parent[i]);
    }    
    public static void Union(int [] parent ,int x,int y){
        int xset=find(parent,x);
        int yset = find(parent,y);
        parent[xset]=yset; 
    }
}
