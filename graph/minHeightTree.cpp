#include<bits/stdc++.h>
using namespace std;
void BFS(vector<vector<int>> graph,int numOfNodes,vector<vector<int>>pre){
    
    vector<int> inDegree(numOfNodes,0);
    for(int i=0;i<pre.size();i++){
        inDegree[pre[i][0]]++;
        inDegree[pre[i][1]]++;
    }
    queue<int> q;
    for(int i=0;i<numOfNodes;i++){
        if(inDegree[i]==1)q.push(i);
    }
    while(numOfNodes > 2){
        int people=q.size();
        numOfNodes-=people;
        for(int i=0;i<people;i++){
            int u=q.front();
            q.pop();
            for(auto itr = graph[u].begin();itr!=graph[u].end();itr++){
                inDegree[*itr]--;
                if(inDegree[*itr]==1)q.push(*itr);
            }
        }
    }
    
    while(!q.empty()){
        cout<<q.front()<<" ";
        q.pop(); 
    }
} 
int main(){
    int numOfNodes=6;
    vector<vector<int>> pre = {{3,0},{3,1},{3,2},{3,4},{5,4}};
    vector<vector<int>> graph(numOfNodes);

    for(int i=0;i<pre.size();i++){
        graph[pre[i][0]].push_back(pre[i][1]);
        graph[pre[i][1]].push_back(pre[i][0]);
    }
    int count=0;
    BFS(graph,numOfNodes,pre);
    return 0;
}