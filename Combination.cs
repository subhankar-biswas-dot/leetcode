using System;
using System.Collections.Generic;
using System.Linq;

public class Combination{
	static void Main(string [] args){
		int n=4;
		int k=2;
		Solution s = new Solution();
		var res = s.printPattern(n,k);
		Console.WriteLine(res[0][0]);

	}
}

class Solution{
	public IList<IList<int>> printPattern(int n,int k){
		IList<IList<int>> res=new List<IList<int>> ();
		IList<int> temp = new List<int>();
		makePattern(res,temp,n,1,k);
        return res;

	}
	public void makePattern(IList<IList<int>> res,IList<int> temp,int n,int left,int k){
		if(k==0){
			res.Add(temp);
			Console.Write(res[0][0]);
			return ;
		}
		for(int i=left;i<=n;++i){
			temp.Add(i);
			makePattern(res,temp,n,i+1,k-1);
			temp.RemoveAt(temp.Count-1);
		}
	}

}