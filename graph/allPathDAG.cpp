#include<bits/stdc++.h>
using namespace std;
void dfs(vector<vector<int>> &graph,vector<vector<int>> &paths,vector<int> &path){
    int lastVisited = path[path.size()-1];
    //cout<<lastVisited<<endl;
    if(lastVisited < graph.size()){
        for(auto i=graph[lastVisited].begin();i!=graph[lastVisited].end();++i){
            auto new_path = path;
            new_path.push_back(*i);
            dfs(graph,paths,new_path);
        }
    }
    else{
        paths.push_back(path);
    }
    
}
int main(){
    vector<vector<int>> graph = {{4,3,1},{3,2,4},{3},{4},{}};
    graph.erase(graph.end());
    vector<int> path = {0};
    vector<vector<int>> paths = {};
    dfs(graph,paths,path);
    cout<<paths.size();
    
}