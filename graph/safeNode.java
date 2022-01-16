package graph;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class safeNode{
    final static int WHITE=0;
    final static int GRAY=1;
    final static int BLACK=2;
    public static void main(String[] args) {
     int [][] graph={{1,2},{2,3},{5},{0},{5},{},{}};
     int len = graph.length;
    
     List<Integer> color = new ArrayList<>(Collections.nCopies(len, WHITE));
     for(int i=0;i<len;i++){
         if(isCycle(graph,i,color))
            System.out.println(i);
     }
    }
    public static Boolean isCycle(int [][] graph,int src,List<Integer> color){
        color.set(src,GRAY);
        for(int in : graph[src]){
            if(color.get(in)==GRAY)
                return true;
            else if(color.get(in)==WHITE && isCycle(graph, in, color))
            return true;
        }
        color.set(src,BLACK);
        return false;
    }
}