package graph;

import java.util.ArrayList;
import java.util.List;


public class RegionsCut{
    public static void main(String[] args) {
        String [] region = {" /","/ "};
        getRegionBySlashes(region);
                
    }
    public static void getRegionBySlashes(String [] region){
        int len = region.length;
        List<Integer> parent = new ArrayList<>();
        for(int i=0;i<4*len*len;i++)
            parent.add(i);
        for(int i=0;i<len;i++){
            for(int j=0;j<len;j++){
                int index=i*4*len+4*j;
                char now = region[i].charAt(j);
                switch(now){
                    case ' ':
                        Union(parent, index, index+1);
                        Union(parent,index+1,index+2);
                        Union(parent,index+2,index+3);
                        break;
                    case '/':
                        Union(parent,index,index+3);
                        Union(parent, index+1, index+2);
                        break;
                    case '\\':
                        Union(parent, index, index+1);
                        Union(parent, index+2, index+3);
                        break;
                }
                if(i+1<len)Union(parent, index+2, index+4*len);
                if(j+1<len)Union(parent,index+1,index+4+3);

            }
        }
        int res=0;
       for(int i=0;i<4*len*len ;i++){
           if(i==parent.get(i))
            res++;
       }
        System.out.println(res);
    }
    public static int find(List<Integer> parent,int i){
            if(parent.get(i)==i)
                return i;
            return find(parent, parent.get(i));       
    }
    public static void Union(List<Integer> parent,int x,int y){
        int xSet=find(parent,x);
        int ySet=find(parent, y);
        parent.set(xSet,ySet);
    }
}