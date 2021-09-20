using System;
using System.Collections.Generic;
using System.Linq;

public class Search2D{
	static void Main(string [] args){
		int [][] matrix = new int [][]{new int [] {1,3,5,7},new int [] {10,11,16,16},new int [] {23,30,34,60}};
		int row = matrix.Length;
		int col=matrix[0].Length;
		Solution s = new Solution();
		s.SearchInMatrix(matrix,col,row,13);		
	}
}

class Solution{
	public void SearchInMatrix(int [][] matrix , int col,int row,int target){
		bool res=false;
		for(int i=0;i<row;i++){
			if(BinarySearch(matrix[i],0,col-1,target)){
				res=true;
				break;
			}
		}
		Console.WriteLine(res);
	}
	public bool BinarySearch(int []array ,int start,int end,int target){
		if(array[start]==target || array[end]==target) return true;
		if(start>=end) return false;
		int mid = start+(end-start)/2;

		if(array[mid]==target) return true;
		else if(array[mid]<target){
			return BinarySearch(array,mid+1,end,target);
		}
		else{
			return BinarySearch(array,start,mid,target);
		}
	}
}