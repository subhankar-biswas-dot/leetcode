#include<bits/stdc++.h>
using namespace std;
int minDistance(vector<int> &dist,vector<bool> &sptSet,int n){
    int min=INT_MAX,min_index;
    for(int i=0;i<n;i++){
        if(sptSet[i]==false && dist[i]<=min ){
            min=dist[i];
            min_index=i;
        }
    }
    return min_index;
}
void dijikstra(vector<vector<int>> graph,int src,int n){
    vector<int> dist(n,INT_MAX);
    vector<bool> sptSet(n,false);
    dist[src]=0;
    for(int count=0;count<n-1;count++){
        int u = minDistance(dist,sptSet,n);
        sptSet[u]=true;
        for(int v=0;v<n;v++){
            if(!sptSet[v] && graph[u][v] && dist[u]!=INT_MAX && dist[u]+graph[u][v]<dist[v]){
                dist[v]=dist[u]+graph[u][v];
            }
        }
    }
    for(int i:dist){
        cout<<i<<endl;
    }
    cout<<endl;
    cout<<*max_element(dist.begin(),dist.end())<<endl;
 
}
int main(){
   vector<vector<int>> edges={{3,5,78},{2,1,1},{1,3,0},{4,3,59},{5,3,85},{5,2,22},{2,4,23},{1,4,43},{4,5,75},{5,1,15},{1,5,91},{4,1,16},{3,2,98},{3,4,22},{5,4,31},{1,2,0},{2,5,4},{4,2,51},{3,1,36},{2,3,59}} ;
   int n=5;
   int k=5;
   vector<vector<int>> graph(n);
   fill(graph.begin(),graph.end(),vector<int>(n,0));

   for(int i=0;i<edges.size();i++){
       graph[edges[i][0]-1][edges[i][1]-1]=edges[i][2];
   }
   for(int i=0;i<graph.size();i++){
       for(int j=0;j<graph[0].size();j++){
           cout<<graph[i][j]<<" ";
       }
       cout<<endl;
   }
   dijikstra(graph,k-1,n);
}