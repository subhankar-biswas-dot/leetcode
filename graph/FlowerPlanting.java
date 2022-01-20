package graph;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;

public class FlowerPlanting {
    final static int INF=99999;
    public static void main(String[] args) {
        int n=5;
        int [][] paths={{4,1},{4,2},{4,3},{2,5},{1,2},{1,5}};
        List<List<Integer>> graph = new ArrayList<>();
        for(int i=0;i<n;i++){
            graph.add(new ArrayList<>());
        }


        for(int i=0;i<paths.length;i++){
            graph.get(paths[i][0]-1).add(paths[i][1]-1);
            graph.get(paths[i][1]-1).add(paths[i][0]-1);
        }

        // printArray(graph);
        getFlower(graph, n);
        

    }
    public static void getFlower(List<List<Integer>> graph,int n){
        int [] result = new int [n];
        for(int i=0;i<n;i++){
            int [] seen = new int[5];
            for(int g :graph.get(i)){
                seen[result[g]]=1;
            }
            for(int garden=1;garden<=4 ;garden++){
                if(seen[garden]==0){
                    result[i]=garden;
                    break;
                }
            }
        }
        System.out.println(Arrays.stream(result).boxed().collect(Collectors.toList()));
    }
    public static void printArray(List<List<Integer>> graph){
        graph.forEach(n->{
            n.forEach(k->{
                System.out.print(k+" ");
            });
            System.out.println();
        });
    }
}
