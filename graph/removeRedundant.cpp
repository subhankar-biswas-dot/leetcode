#include<bits/stdc++.h>
using namespace std;
void DFS(vector<vector<int>> graph,vector<int> &visited,vector<int> &res,int root){
    visited[root]=1;
    res.push_back(root);
    for(auto i=graph[root].begin();i!=graph[root].end();++i){
        if(visited[*i]==0){
            
            DFS(graph,visited,res,*i);
        }
    }
}
int isConnected(vector<vector<int>> graph , int source ,int dest){
    if(find(graph[source].begin(),graph[source].end(),dest)!=graph[source].end()){
        graph[source].erase(find(graph[source].begin(),graph[source].end(),dest));
        graph[dest].erase(find(graph[dest].begin(),graph[dest].end(),source));
    }
    vector<int> visited(graph.size(),0);
    vector<int> res;
    DFS(graph,visited,res,0);
    // for(auto i:res){
    //     cout<<i<<" ";
    // }
    // cout<<endl;

    return res.size();
}
int main(){
    vector<vector<int>> edges = {{1,2},{2,3},{3,4},{1,4},{1,5}};
    vector<vector<int>> graph(edges.size());

    for(int i=0;i<edges.size();i++){
        graph[edges[i][0]-1].push_back(edges[i][1]-1);
        graph[edges[i][1]-1].push_back(edges[i][0]-1);
    }
    for(int i=edges.size()-1;i>=0;i--){
        
        int size=isConnected(graph,edges[i][0]-1,edges[i][1]-1);
        if(size==graph.size()){
            
            cout<<edges[i][0]<<" "<<edges[i][1]<<endl;
            break;
        } 
      }
    
}