#include<bits/stdc++.h>
using namespace std;
bool isPalindrom(string str,int i,int j){
    if(i>j)return true;
    else if(str.at(i)!=str.at(j)) return false;
    return isPalindrom(str,i+1,j-1);
}
void palindromPartition(string str,int start,int end,vector<string> &curr,vector<vector<string>> &res){
    if(start>=end){
        res.push_back(curr);
        return;
    }
    for(int i=start;i<end;i++){
        if(isPalindrom(str,start,i)){
            // cout<<str.substr(start,i+1-start)<<endl;
            curr.push_back(str.substr(start,i+1-start));
            palindromPartition(str,i+1,end,curr,res);
            curr.erase(curr.end());
        }
    }
}
int main(){
    string str = "aab";
    int length = str.length();
    vector<string> curr;
    vector<vector<string>> res ;
    palindromPartition(str,0,length,curr,res);
    for(auto i=0;i< res.size();i++){
        for(auto j = res[i].begin();j!=res[i].end();++j){
            cout<< *j <<" ";
        }
        cout<<endl;
    }
}