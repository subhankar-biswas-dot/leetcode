using System;
using System.Collections.Generic;
using System.Linq;

public class FindInRotatedList{
	static void Main(string [] args){
		int [] data = new int [] {1};
		Search(data,1);
	}
	static void Search(int [] data,int target){
		int i=0;
		int arrlen=data.Length;
		while(i<arrlen-1){
			if(data[i]>data[i+1])
				break;
			i++;
		}
		int [] first = data.Take(i+1).ToArray();
		int [] second = data.Skip(i+1).ToArray();

		foreach(var k in first){
			Console.WriteLine(k);
		}

		Console.WriteLine(bSearch(second,0,second.Length,target) || bSearch(first,0,i+1,target));

	}
	static bool bSearch(int [] data,int start,int end,int target){
		int mid = start+(end-start)/2;
		if(start>=end) return false;
		if(data[mid]==target){
			return true;
		}
		else if(data[mid]>target)
			return bSearch(data,start,mid,target);
		else
			return bSearch(data,mid+1,end,target);

	}
}