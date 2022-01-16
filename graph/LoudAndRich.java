package graph;

public class LoudAndRich {
    static int res=0;
    static int comp=0;
    public static void main(String[] args) {
        int [][] richer={{}};
        int [] loud={0};
        int n = loud.length;
        int [] answer=new int[n];
        for(int i=0;i<n;i++){
            answer[i]=i;
        }
        int [][] graph = new int[n][n];
        if(graph[0].length ==0 || n==1)
            System.out.println("break");
        for(int [] rich:richer){
            graph[rich[1]][rich[0]]=1;
        }
        // for(int i=0;i<n;i++){
        //     for(int j=0;j<n;j++){
        //         System.out.print(graph[i][j]+" ");
        //     }
        //     System.out.println();
        // }
        for(int i=0;i<n;i++){
            int [] visited = new int[n];
            //System.out.print(i+ " ----> ");
            comp=loud[i];
            res=i;
            DFS(graph, i, visited,loud);
            answer[i]=res;
        }
        for(int i: answer){
            System.out.print(i+" ");
        }
    }

    public static void DFS(int [][] graph,int src,int [] visited,int [] loud){
        visited[src]=1;
        //System.out.print(src+" ");
        if(loud[src]<comp){

            comp=Math.min(comp,loud[src]);
            res=src;
        }
        //res=Math.min(res, loud[src]);
        for(int i=0;i<graph[src].length;i++){
            if(visited[i]==0 && graph[src][i]==1)
                DFS(graph, i, visited,loud);
        }
    }
}
