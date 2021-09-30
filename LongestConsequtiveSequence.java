import java.util.*;
import java.io.*;
import static java.lang.System.*;
public class LongestConsequtiveSequence{
	public static void main(String [] args){
		int [] nums = {100,4,200,1,3,2};

		HashSet<Integer> set = new HashSet<Integer>();
		int n = nums.length;
		int ans =0;
		for(int i=0;i<n;i++){
			set.add(nums[i]);
		}
		for(int i=0;i<n;i++){
			if(!set.contains(nums[i]-1)){
				int j = nums[i];
				while(set.contains(j))
					j++;
				if(ans<j-nums[i]) ans = j-nums[i];
			}
		}
		out.println(ans);
	}
}