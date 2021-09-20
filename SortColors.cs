using System;
using System.Collections.Generic;
using System.Linq;

public class SortColors{
	static void Main(string [] args){
		int [] array = new int [] {2,0,2,1,1,0};
		Solution s = new Solution();
		s.sortColors(array);

	}
}

class Solution{
	public void sortColors(int [] array){
		int high = array.Length-1;
		int low =0;
		int mid =0;
		while(mid <= high){
			switch(array[mid]){

				case 0:{
					swap(array,low,mid);
					low++;
					mid++;
					break; 
				}
				case 1:{
					mid++;
					break;
				}
				case 2:{
					swap(array,mid,high);
					high--;
					break;	
				}
			}
		}
		foreach(var ele in array){
			Console.WriteLine(ele);
		}
	}
	public void swap(int [] array,int a,int b){
		int temp = array[a];
		array[a]=array[b];
		array[b]=temp;
	}
}