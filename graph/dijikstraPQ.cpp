#include<bits/stdc++.h>
#define INF 0x3f3f3f3f

using namespace std;
void dijikstraPQ(vector<vector<int>> graph,int src){
    priority_queue<pair<int,int>,vector<pair<int,int>>,greater<pair<int,int>> > pq;
    vector<int> dist(graph.size(),INF);
    pq.push(make_pair(0,src));
    dist[src]=0;
    while(!pq.empty()){
        unordered_set<int> visited;
        int u = pq.top().second;
        pq.pop();
        for(int v=0;v<graph[u].size();v++){
            if(graph[u][v]!=-1 && dist[v]>dist[u]+graph[u][v]){

                    if(!visited.count(v)){
                        visited.insert(v);
                        pq.push(make_pair(dist[v],v));

                    }
                dist[v]=dist[u]+graph[u][v];
                
            }
        }
    }
    for(auto i: dist){
        cout<<i<<" ";
    }

}
int main(){
   //vector<vector<int>> edges={{3,5,78},{2,1,1},{1,3,0},{4,3,59},{5,3,85},{5,2,22},{2,4,23},{1,4,43},{4,5,75},{5,1,15},{1,5,91},{4,1,16},{3,2,98},{3,4,22},{5,4,31},{1,2,0},{2,5,4},{4,2,51},{3,1,36},{2,3,59}} ;
   vector<vector<int>> edges = {{2,1,1},{2,3,1},{3,4,1}};
   int n=4;
   int k=2;
   vector<vector<int>> graph(n);
   fill(graph.begin(),graph.end(),vector<int>(n,-1));

   for(int i=0;i<edges.size();i++){
       graph[edges[i][0]-1][edges[i][1]-1]=edges[i][2];
   }
   dijikstraPQ(graph,k-1);
}