using System;
using System.Collections.Generic;
using System.Linq;

public class SetMatZero{
	static void Main(string [] args){
		int [][] matrix = new int[][]{new int[]{0,1,2,0},new int[]{3,4,5,2},new int[]{1,3,1,5}};
		Solution s = new Solution();
		s.putZeros(matrix,matrix.Length,matrix[0].Length);
	}
}
class Solution{
	public void putZeros(int [][] matrix,int r,int c){
		for(int i=0;i<r;i++){
			for(int j=0;j<c;j++){
				if(matrix[i][j]==0){
					matrix[i][0]=-1;
					matrix[0][j]=-1;
				}
			}
		}
		for(int i=0;i<c;i++){
			if(matrix[0][i]==-1){
				
				for(int j=0;j<r;j++){
					if(matrix[j][i]!=-1)
						matrix[j][i]=0;
				}
			}
		}
		for(int i=0;i<r;i++){
			if(matrix[i][0]==-1){
				for(int j=0;j<c;j++){
					if(matrix[i][j]!=-1)
						matrix[i][j]=0;
				}
			}
		}
		for(int i=0;i<c;i++){
			if(matrix[0][i]==-1)
				matrix[0][i]=0;
		}
		for(int i=0;i<r;i++){
			if(matrix[i][0]==-1)
				matrix[i][0]=0;
		}
		for(int i=0;i<r;i++){
			for(int j=0;j<c;j++){
				
					Console.Write(matrix[i][j]+" ");
			}
			Console.WriteLine();
		}
	}
	
}