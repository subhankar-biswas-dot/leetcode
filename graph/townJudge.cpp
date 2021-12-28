#include<bits/stdc++.h>
using namespace std;
void getTheJudge(unordered_map<int,vector<int>> map,int n,int &result){
    
    for(int i=1;i<=n;i++){
        if(map.find(i)!=map.end()){
            continue;
        }
        else{
            for(int j=1;j<n;j++){
                if(j==i) continue;
                else{
                    if(find(map[j].begin(),map[j].end(),i)==map[j].end()) return;
                }
            }
            result = i;
        }
    }
    
}
int main(){
    vector<vector<int>> trust ={};
    int n = 1;
    int result=-1;
    unordered_map<int,vector<int>> map;
    for(auto i=0;i<trust.size();i++){
        if(map.find(trust[i][0])==map.end())
            map.insert(make_pair(trust[i][0],vector<int>{trust[i][1]}));
        else{
            auto v = map[trust[i][0]];
            v.push_back(trust[i][1]);
            map.insert(make_pair(trust[i][0],v));
        }
    }
    if(map.empty()) return n;
    getTheJudge(map,n,result);
    cout<<result<<endl;
}