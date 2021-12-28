#include<bits/stdc++.h>
using namespace std;
bool sortcol( const vector<int>& v1,
               const vector<int>& v2 ) {
 return v1[0] < v2[0];
}
void bellmanFord(vector<vector<int>> graph,int n,int k,int src,int dest){
    vector<int> dist(n,INT_MAX);
   // sort(graph.begin(),graph.end(),sortcol);
    dist[src]=0;
    vector<int>alreadyChanged(n,0);
    for(int i=0;i<=k;i++){
        vector<int> temp(dist);
        for(int j=0;j<graph.size();j++){
            int u = graph[j][0];
            int v = graph[j][1];
            int w = graph[j][2];
            // if(dist[u]!=INT_MAX && temp[u]+w<dist[v]){
            //     // if(v!=dest && alreadyChanged[u]+1 > k){
            //     //     continue;
            //     // }
            //     // if(v==dest && alreadyChanged[u]+1<=k+1){
            //     //     alreadyChanged[v]=alreadyChanged[u]+1;
            //     // }
            //     // else if(v!=dest && alreadyChanged[u]+1 <=k+1){
            //     //     alreadyChanged[v]=alreadyChanged[u]+1;
            //     // }
            //     // else {
            //     //     continue;
            //     // }
            //     temp[v]=dist[u]+w;
            // }
            if(dist[u]!=INT_MAX)
                temp[v]=min(temp[v],dist[u]+w);
            
        }
        dist=temp;
    }
    for(int i: dist){
        cout<<i<<" ";
    }
}

int main(){
    vector<vector<int>> graph={{0,1,5},{1,2,5},{0,3,2},{3,1,2},{1,4,1},{4,2,1}};
    int k =2;
    int n=5;
    bellmanFord(graph,n,k,0,2);

}
