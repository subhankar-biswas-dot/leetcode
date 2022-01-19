package graph;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

public class Flloyd_Warshall {
    public static void main(String[] args) {
        int n=5;
        int [][] edges ={{0,1,2},{0,4,8},{1,2,3},{1,4,2},{2,3,1},{3,4,1}};
        int [][] graph = new int [n][n];
        for(int i=0;i<edges.length;i++){
            graph[edges[i][0]][edges[i][1]]=edges[i][2];
            graph[edges[i][1]][edges[i][0]]=edges[i][2];

        }
        printArray(graph, n);
        System.out.println();
        fllowdWarshall(graph, n);

    }  
    public static void fllowdWarshall(int [][] graph,int n){
        int INF=99999;
        int [][] dist = new int[n][n];
        for(int i=0;i<n;i++){
            for(int j=0;j<n;j++){
                if(i!=j && graph[i][j]==0)
                    dist[i][j]=INF;
                else
                    dist[i][j]=graph[i][j];
            }
        }
        printArray(dist, n);
        System.out.println();
        for(int k=0;k<n;k++){
            for(int i=0;i<n;i++){
                for(int j=0;j<n;j++){
                    if(dist[i][k]+dist[k][j]<dist[i][j])
                        dist[i][j]=dist[i][k]+dist[k][j];
                }
            }
        }
        printArray(dist, n);
        System.out.println();
        getList(dist, n, 2);

    }
    public static void getList(int [][] dist,int n,int maxDist){
        HashMap<Integer,List<Integer>> map= new HashMap<>();
        for(int i=0;i<n;i++){
            for(int j=0;j<n;j++){

                if(!map.containsKey(i)){
                    map.put(i, new ArrayList<>());
                    if(dist[i][j]<=maxDist && i!=j)
                        map.get(i).add(j);
                }
                else if(map.containsKey(i) && dist[i][j]<=maxDist && i!=j){
                    
                    map.get(i).add(j);
                }

            }    
        }
        int numOfEle=Integer.MAX_VALUE;
        int ans=0;
        for(int i=0;i<n;i++){
            if(numOfEle>=map.get(i).size()){
                numOfEle=Math.min(numOfEle, map.get(i).size());
               // System.out.println(map.get(i).size()+" "+numOfEle);
                ans=i;
                //System.out.println(ans);
            }
                
        }
        System.out.println(ans);
    }
    public static void printArray(int [][] dist,int n){
        for(int i=0;i<n;i++){
            for(int j=0;j<n;j++){
                System.out.print(dist[i][j]+" ");
            }
            System.out.println();
        }
    } 
}
