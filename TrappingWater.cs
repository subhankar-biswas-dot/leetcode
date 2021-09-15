using System;

public class TrappingWater{
	static void Main(string [] args){
		int [] array = {0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1};
		int res=0;
		int n=array.Length;
		for(int i=1;i<n-1;i++){
			int left=array[i];
			for(int j=0;j<i;j++)
				left=Math.Max(left,array[j]);
			int right=array[i];
			for(int j=i;j<n;j++)
				right=Math.Max(right,array[j]);

			res+= Math.Min(left,right)-array[i];
			Console.WriteLine(res);
		}
		Solution s = new Solution();
		int k = s.TrappingRain(n,array);
		Console.WriteLine(k);
	}
}
class Solution{
	public int TrappingRain(int n,int [] array){
		int [] right = new int [n];
		int [] left = new int [n];
		int water=0;
		left[0]=array[0];
		for(int i=1;i<n;i++)
			left[i]=Math.Max(left[i-1],array[i]);
		right[n-1]=array[n-1];
		for(int i=n-2;i>=0;i--)
			right[i]=Math.Max(right[i+1],array[i]);

		for(int i=0;i<n;i++)
			water+=Math.Min(right[i],left[i])-array[i];

		Console.WriteLine(water);
		return water;
	}
}