#include<bits/stdc++.h>
using namespace std;

int main(){
    int numCourses = 4;
    vector<vector<int>> pre = {{1,0},{2,0},{3,1},{3,2}};
    vector<vector<int>> graph(numCourses);
    for(int i=0;i<pre.size();i++){
        graph[pre[i][1]].push_back(pre[i][0]);
    }

    vector<int> inDegree(numCourses,0);

    for(int u=0;u<numCourses;u++){
        for(auto itr = graph[u].begin();itr!=graph[u].end();++itr){
                inDegree[*itr]++;   
        }
    }

    queue<int> q;
    for(int i=0;i<numCourses;i++){
        if(inDegree[i]==0) q.push(i);
    }
    int cnt=0;

    while(!q.empty()){
        int u = q.front();
        q.pop();
        for(auto itr=graph[u].begin();itr!=graph[u].end();++itr){
            if(--inDegree[*itr]==0)q.push(*itr);
        }
        cnt++;

    }
    cout<<(cnt==numCourses);
    return 0;
}