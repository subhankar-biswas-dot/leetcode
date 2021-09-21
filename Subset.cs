using System;
using System.Collections.Generic;
using System.Linq;

public class Subset{
	static void Main(string [] args){
		int [] arr = new int [] {1,2,3,4,5};
		int r = 3;
		int len = arr.Length;
		combination(arr,len,r);

	}
	static void combinationUtil(int [] arr,int n,int r,int [] data,int index,int i,IList<IList<int>> res){
		if(index ==r){
			// for(int j=0;j<r;j++)
			// 	Console.Write(data[j]+" ");
			// Console.WriteLine("");
			res.Add(data.ToList());
			return;
		}
		if(i>=n)
		 return;
		data[index]=arr[i];
		combinationUtil(arr,n,r,data,index+1,i+1,res);
		combinationUtil(arr,n,r,data,index,i+1,res);
	}
	static void combination(int [] arr,int n,int r){
		IList<IList<int>> res = new List<IList<int>>();
		IList<int> temp = new List<int>();
		res.Add(temp);
		res.Add(arr.ToList());
		for(int i=1;i<n;i++){

			int [] data = new int [i];
			combinationUtil(arr,n,i,data,0,0,res); 
		}
		Console.WriteLine(res[1][1]);
	}
}