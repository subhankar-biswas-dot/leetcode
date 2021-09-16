using System;
using System.Collections.Generic;
using System.Linq;

public class SpiralMatrix{
	static void Main(string [] args){

		int [][] matrix = new int [][] {new int[] {1,2,3,4},new int[] {5,6,7,8},new int[] {9,10,11,12}};
		int r = matrix.Length;
		int c = matrix[0].Length;
		Solution s = new Solution();
		IList<int> ilist = new List<int>();
		var res = s.spiralMatrix(matrix,0,0,r,c,ilist);
		foreach(var result in res)
			Console.Write(result+" ");
	}
}

class Solution{
	public IList<int> spiralMatrix(int [][] matrix,int i,int j,int r,int c,IList<int> ilist){
		if(i>=r || j>=c)
			return ilist;
		for(int p=i;p<c;p++){
			ilist.Add(matrix[i][p]);
			Console.WriteLine(matrix[i][p]+" ");
		}
		for(int p=i+1;p<r;p++){
			ilist.Add(matrix[p][c-1]);
			Console.WriteLine(matrix[p][c-1]+" ");
		}
		if(r-1!=i){
			for(int p=c-2;p>=j;p--){
				ilist.Add(matrix[r-1][p]);
				Console.WriteLine(matrix[r-1][p]+" ");
			}
		}
		if(c-1!=j){
			for(int p=r-2;p>i;p--){
				ilist.Add(matrix[p][j]);
				Console.WriteLine(matrix[p][j]+" ");
			}
		}

		return spiralMatrix(matrix,i+1,j+1,r-1,c-1,ilist);
	}
}
