#include <bits/stdc++.h>

using namespace std;

void makeCombinationHelper(vector<vector<int>> &res,vector<int> &temp,int left,int n,int k){
	if(k==0){
		res.push_back(temp);
		return;
	}
	for(int i=left;i<=n;i++){
		temp.push_back(i);
		makeCombinationHelper(res,temp,i+1,n,k-1);
		temp.pop_back();
	}
}
vector<vector<int>> makeCombi(int n,int k){
	vector<vector<int>> res;
	vector<int> temp;
	makeCombinationHelper(res,temp,1,n,k);
	return res;
}

int main()
{
	vector<vector<int>> res=makeCombi(4,2);
	cout<<res[0][0];

	return 0;
}
