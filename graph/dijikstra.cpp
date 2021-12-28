#include<bits/stdc++.h>
using namespace std;
int minDistance(vector<bool> &sptSet,vector<int> &dist){
    int min=INT_MAX,min_index;
    for(int i=0;i<sptSet.size();i++){
        if(sptSet[i]==false && dist[i]<=min){
            min=dist[i];
            min_index=i;
        }
    }
    return min_index;
}
void printMinDistance (vector<int> &dist){
    for(int i:dist){
        cout<<i<<" ";
        
    }
    cout<<"\n";
}
void dijikstras(vector<vector<int>> graph,int src){
    vector<int> dist(graph.size(),INT_MAX);
    vector<bool> sptSet(graph.size(),false);
    dist[src]=0;

    for(int count=0;count<graph.size()-1;count++){
        int u = minDistance(sptSet,dist);
        sptSet[u]=true;
        for(int v=0;v<graph.size();v++){
            if(!sptSet[v] && graph[u][v] && dist[u]!=INT_MAX && dist[u]+graph[u][v] < dist[v] )
                dist[v]=dist[u]+graph[u][v];
        }
    }
    printMinDistance(dist);

}

int main(){
    vector<vector<int>> graph ={{0,0,0,0},{1,0,1,0},{0,0,0,1},{0,0,0,0}};
    dijikstras(graph,1);

}