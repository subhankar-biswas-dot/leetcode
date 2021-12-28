#include<bits/stdc++.h>
using namespace std;
void dfs(vector<vector<int>> &isConnected,vector<int> &visited,int v){
    visited[v]=1;
    for(int i=0;i<isConnected[v].size();i++){
        if(visited[i]==0 && isConnected[v][i]==1){
            
            dfs(isConnected,visited,i);
        }
    }
}
int main(){
    vector<vector<int>> isConnected={{1,1,0},{1,1,0},{0,0,1}};
    int V=isConnected.size();
    int count =0;
    vector<int> visited(V,0);
    for(int v=0;v<V;v++){
        if(visited[v]==0){
            dfs(isConnected,visited,v);
            count++;
        }
        
    }
    cout<<count<<endl;

}