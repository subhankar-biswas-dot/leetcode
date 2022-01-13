package graph;

import java.util.*;
import java.util.stream.Collectors;
import java.util.stream.IntStream;

public class verticesToReach{
    public static void main(String[] args) {
       List<List<Integer>> li = Arrays.asList(Arrays.asList(0,1),Arrays.asList(2,1),Arrays.asList(3,1),Arrays.asList(1,4),Arrays.asList(2,4));
       int size = 5;
       List<List<Integer>> graph= IntStream.range(0, size).mapToObj(i->new ArrayList<Integer>(Collections.nCopies(size, 0))).collect(Collectors.toList());
       
       li.forEach((n)->{
           graph.get(n.get(0)).set(n.get(1),1);
       });
       //System.out.println(graph);
       List<Integer> res=new ArrayList<>();
       for(int i=0;i<size;i++){
           res.add(i);
       }
       for(int i=0;i<size;i++){
           List< Boolean > isVisited= new ArrayList<>(Collections.nCopies(size, false));          
           DFS(graph, isVisited, i);
           isVisited.set(i, false);
           for(int j=0;j<size;j++){
               if(isVisited.get(j)){
                   res.set(j,-1);
               }
           }
       }
       res.removeAll(Collections.singleton(-1));
       System.out.println(res);
    }
    public static void DFS(List<List<Integer>> graph,List<Boolean> isVisited,int src){
        isVisited.set(src, true);
        for(int i=0;i<graph.get(src).size();i++){
            if(graph.get(src).get(i)==1 && isVisited.get(i)==false)
                DFS(graph,isVisited,i);
        }
    }
}