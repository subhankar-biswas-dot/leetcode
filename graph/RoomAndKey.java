package graph;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Collections;
import java.util.LinkedList;
import java.util.List;

public class RoomAndKey {
    public static void main(String[] args) {
        List<List<Integer>> rooms = Arrays.asList(Arrays.asList(1,3),Arrays.asList(3,0,1),Arrays.asList(2),Arrays.asList(0));
        List<Boolean> visited=new ArrayList(Collections.nCopies(rooms.size(), false));
        List<Integer>res=new ArrayList<>();      
        BFS(rooms,visited,0,res);
        
    }
    public static void BFS(List<List<Integer>> rooms,List<Boolean> visited,int src,List<Integer> res){
        LinkedList<Integer> queue = new LinkedList<>();
        queue.add(src);
        visited.set(src,true);
        while(!queue.isEmpty()){
            int s = queue.poll();
            res.add(s);
            List<Integer> tmp = rooms.get(s);
            for(int i=0;i<tmp.size();i++){
                if(!visited.get(tmp.get(i))){
                    visited.set(tmp.get(i), true);
                    queue.add(tmp.get(i));
                }
            }
        }
        
    }    
}
