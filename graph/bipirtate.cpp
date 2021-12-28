#include<bits/stdc++.h>
using namespace std;
bool isBipartiteUtil(vector<vector<int>> graph,int src,vector<int> &color){
    color[src]=1;
    queue<int> q;
    q.push(src);
    while(!q.empty()){
        int u=q.front();
        q.pop();
        for(auto v=graph[u].begin();v!=graph[u].end();++v){
            if(color[*v]==-1){
                color[*v]=1-color[u];
                q.push(*v);
            }
            else if(color[*v]==color[u])
                return false;
        }
    }
    return true;
}
void isBipartite(vector<vector<int>> graph){
    int n=graph.size();
    vector<int> color(n,-1);
    for(int i=0;i<n;i++){
        if(color[i]==-1){
            if(!isBipartiteUtil(graph,i,color)){
                cout<<"False"<<endl;
                return;
            }
                
        }
    }
    cout<<"True"<<endl;
}
int main(){
    vector<vector<int>> graph = {{1,2,3},{0,2},{0,1,3},{0,2}};
    int n = graph.size();

    isBipartite(graph);

}