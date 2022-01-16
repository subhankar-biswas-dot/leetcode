package graph;

public class MaximumNetworkRank {
    public static void main(String[] args) {
        int [][] roads = {{0,1},{1,2},{2,3},{2,4},{5,6},{5,7}};
        int n=8;

        int [][] graph = new int[n][n];
        for(int [] road:roads){
            graph[road[0]][road[1]]=1;
            graph[road[1]][road[0]]=1;
        }
        int [] inDegree = new int[n];
        for(int [] g:graph){
            for(int i=0;i<n;i++){
                if(g[i]==1)
                    inDegree[i]++;
            }
        }
        int max=0;
        int p1=-1;
        int p2=-1;
        for(int i=0;i<n;i++){
            for(int j=0;j<n;j++){
                if(j==i)continue;
                if(graph[i][j]!=1 && inDegree[i]+inDegree[j]>max){

                    p1=i;p2=j;
                    max=inDegree[i]+inDegree[j];
                }
                else if(graph[i][j]==1 && inDegree[i]+inDegree[j]-1 >max){
                    p1=i;p2=j;
                    max=inDegree[i]+inDegree[j]-1;
                }
            }
        }

        for(int i:inDegree){
            System.out.print(i+" ");
        }

        System.out.print(max);
        
    }
}
