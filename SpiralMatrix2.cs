using System;
using System.Collections.Generic;
using System.Linq;

public class SprialMatrix2{
	static void Main(string [] args){
		int n = 3;
		int [][] res = Enumerable.Range(0, n).Select(i=>new int[n]).ToArray();
		Solution s=new Solution();

		var result=s.sprialMatrix2(0,0,n,res,1);
		for(int i=0;i<n;i++){
			for(int j=0;j<n;j++){
				Console.Write(result[i][j]+" ");
			}
			Console.WriteLine();
		}

	}

}

class Solution{
	public int [][] sprialMatrix2(int i,int j,int n,int [][] matrix,int count){
		if(i>=n || j>=n) return matrix;
		for(int p=i;p<n;p++){
			matrix[i][p]=count++;
			Console.WriteLine(i+" "+p);
		}
		for(int p=i+1;p<n;p++){
			matrix[p][n-1]=count++;
			Console.WriteLine(p+" "+(n-1));
		}
		if(n-1!=i){
			for(int p=n-2;p>=j;p--){
				matrix[n-1][p]=count++;
				Console.WriteLine((n-1)+" "+p);
			}
		}
		if(n-1!=j){
			for(int p=n-2;p>i;p--){
				matrix[p][j]=count++;
				Console.WriteLine(p+" "+j);
			}
		}
		return sprialMatrix2(i+1,j+1,n-1,matrix,count);
	}
}