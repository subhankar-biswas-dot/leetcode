#include<bits/stdc++.h>
using namespace std;
bool isPallindrome(string str,int i,int j){
    if(i>j) return true;
    else if(str.at(i)!=str.at(j)) return false;
    return isPallindrome(str,i+1,j-1);
}
int minCut(string str,int i,int j){
    if(i>=j || isPallindrome(str,i,j)) return 0;
    int ans = INT_MAX,count;
    for(int k=i;k<j;k++){
        count = minCut(str,i,k)+minCut(str,k+1,j)+1;
        ans=min(ans,count);
    }
    return ans;
}
int minCut(string str){
    int cut[str.length()];
    bool palindrome[str.length()][str.length()];
    memset(palindrome,false,sizeof(palindrome));
    for(int i=0;i<str.length();i++){
        int minCut=i;
        for(int j=0;j<=i;j++){
            if(str.at(i)==str.at(j) && (i-j<2 || palindrome[j+1][i-1]) ){
                palindrome[j][i]=true;
                minCut = min(minCut,j==0?0:cut[j-1]+1);
            }
            cut[i]=minCut;
        }
    }
    return cut[str.length()-1];
}
int main(){
    string str = "aab";
    cout<<minCut(str);
}