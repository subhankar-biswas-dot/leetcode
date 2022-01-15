package graph;

import java.util.ArrayList;
import java.util.Collection;
import java.util.Collections;
import java.util.LinkedList;
import java.util.List;
import java.util.stream.Collectors;
import java.util.stream.IntStream;

public class ReorderRoutes {
    static int count =0;
    public static void main(String[] args) {
        int [][] routes = {{1,0},{1,2},{3,2},{3,4}};
        int len = 5;
        int [][] graph=new int[len][len];
        for(int i=0;i<routes.length;i++){
            graph[routes[i][0]][routes[i][1]]=1;
            graph[routes[i][1]][routes[i][0]]=-1;
        }
        int [] visited=new int[len];
        BFS(graph, visited);
        System.out.println(count);

    }
    public static void DFS(int[][] graph,int[] visited,int src){
        visited[src]=1;
        System.out.println(src+" "+count);
        for(int i=0;i<graph[src].length;i++){
            if(visited[i]==0 && graph[src][i]!=0){
                if(graph[src][i]==1)count++;
                DFS(graph, visited, i);
            }

        }
    }
    public static void BFS(int [][] graph,int [] visited){
        LinkedList<Integer> queue=new LinkedList<>();
        queue.add(0);
        visited[0]=1;
        while(!queue.isEmpty()){
            int s=queue.poll();
            for(int i=0;i<graph[s].length;i++){
                if(graph[s][i]!=0 && visited[i]==0){
                    if(graph[s][i]==1)count++;
                    queue.add(i);
                    visited[i]=1;
                }
            }
        }
    }
}    
