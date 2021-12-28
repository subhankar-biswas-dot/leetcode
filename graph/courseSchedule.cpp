#include<bits/stdc++.h>
using namespace std;

int main(){
    int numOfCourses=4;
    vector<vector<int>> pre={{1,0},{2,0},{3,1},{3,2}};
    vector<vector<int>> graph(numOfCourses);
    for(int i=0;i<pre.size();i++){
        graph[pre[i][1]].push_back(pre[i][0]);
    }
    vector<int> inDegree(numOfCourses,0);
    for(int u=0;u<numOfCourses;u++){
        for(auto i=graph[u].begin();i!=graph[u].end();++i){
            inDegree[*i]++;
        }
    }
    queue<int> q;
    for(auto i=0;i<numOfCourses;i++){
        if(inDegree[i]==0) q.push(i);

    }
    vector<int> result;
    int cnt=0;
    while( !q.empty()){
        int u =q.front();
        result.push_back(u);
        q.pop();
        for(auto i=graph[u].begin();i!=graph[u].end();++i){
            if(--inDegree[*i] == 0) q.push(*i);
        }
        cnt++;
    }
    for(auto i:result){
        cout<<i<<endl;
    }
    cout<<(cnt==numOfCourses)<<endl;
    return 0;
}   