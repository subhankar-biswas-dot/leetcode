using System;
using System.Collections.Generic;
using System.Linq;

public class Subset2{
	static void Main(string [] args){
		int [] data = new int []{4,4,4,1,4};
		var list = SubsetsWithDup(data);
		Console.WriteLine(list.Count);
	}
	static IList<IList<int>> SubsetsWithDup(int[] nums){
		IList<int> temp=new List<int>();
		IList<IList<int>> res = new List<IList<int>>();
		res.Add(temp);
		res.Add(nums.ToList());
		for(int i=1;i<nums.Length;i++){
			int [] data = new int [i];
			combinationUtil(nums,nums.Length,data,i,0,0,res);
		}
		return res;
	}
	static void combinationUtil(int [] arr,int n,int [] data,int r,int index,int i ,IList<IList<int>> res){
		if(index==r){
			
			foreach(var a in res){
                List<int> t=a.ToList();
                t.Sort();
                var temp = data.ToList();
                temp.Sort();
				if(t.SequenceEqual(temp)){
					return;
				}
			}
			res.Add(data.ToList());
			return;
		}
		if(i>=n) return;

		data[index]=arr[i];

		combinationUtil(arr,n,data,r,index+1,i+1,res);
		combinationUtil(arr,n,data,r,index,i+1,res);
	}
}