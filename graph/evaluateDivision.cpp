#include<bits/stdc++.h>
using namespace std;

double dfs(unordered_map<string,unordered_map<string,double>> &graph,string source,string dest,set<string> &visited){
    if(graph.find(source)==graph.end()) return -1.0;
    if(graph[source].find(dest)!=graph[source].end()) return graph[source][dest];
    visited.insert(source);
    for(auto i:graph[source]){
        if(visited.find(i.first)==visited.end()){
            double ans = dfs(graph,i.first,dest,visited);
            if(ans!=-1.0) return(ans*i.second);
        }
        
    }
    return -1.0;

}
int main(){
    vector<vector<string>> equation={{"a","b"},{"b","c"}};
    vector<double> values={2.0,3.0};
    vector<vector<string>> quaries={{"a","c"},{"b","a"},{"a","e"},{"a","a"},{"x","x"}};

    unordered_map<string,unordered_map<string,double>> graph;

    for(int i=0;i<equation.size();i++){
        string source = equation[i][0];
        string dest = equation[i][1];

        if(graph.find(source)!=graph.end()){
            graph[source].insert(make_pair(dest,values[i]));
        }
        else{
            unordered_map<string,double> temp;
            temp.insert(make_pair(dest,values[i]));
            graph.insert(make_pair(source,temp));
        }

        if(graph.find(dest)!=graph.end()){
            graph[dest].insert(make_pair(source,1/values[i]));
        }
        else{
            unordered_map<string,double> temp1;
            temp1.insert(make_pair(source,1/values[i]));
            graph.insert(make_pair(dest,temp1));
        }
    }

    vector<double> res;
    
    for(int i=0;i<equation.size();i++){
        set<string> visited;
        res.push_back(dfs(graph,equation[i][0],equation[i][1],visited));
    }
    
}