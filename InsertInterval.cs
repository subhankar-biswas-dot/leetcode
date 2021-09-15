using System;
using System.Collections.Generic;
using System.Linq;
public class InsertInterval{
	static void Main(string [] args){
		int [][] intervals = new int[][] {new int[] {1,2},new int[] {3,5},new int[] {6,7},new int[] {8,10},new int[] {12,16}};
		int [] new_element={4,8};

		Solution s = new Solution();
		s.InsertInterval(intervals,new_element,intervals.Length);
	}
}

class Solution{
	public void InsertInterval(int [][] intervals,int [] new_element,int n){
		List<int> li = new_element.ToList();
		List<List<int>> list = intervals.Select(X=>X.ToList()).ToList();
		list.Add(li);
		list.Sort((a,b)=>a[0].CompareTo(b[0]));
		List<List<int>> result=new List<List<int>>();
		for(int i=0;i<n+1;i++){
			if(result.Count==0){
				result.Add(list[i]);
			}
			else if(result[result.Count-1][1] >= list[i][0]){
				result[result.Count-1][1]=Math.Max(result[result.Count-1][1],list[i][1]); 
			}
			else{
				result.Add(list[i]);
			}
		}
		int [][] arrays = result.Select(a=> a.ToArray()).ToArray();
		foreach(var res in arrays){
			Console.WriteLine(res[0]+" "+res[1]);
		}
	}
}