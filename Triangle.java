import java.util.*;
import java.io.*;
import static java.util.Arrays.*;

public class Triangle{
	public static void main(String [] args){
		List<List<Integer>> mat = asList(asList(2),asList(3,4),asList(6,5,7),asList(4,1,8,3));
		System.out.println(minimumTotal(mat));
	}
	public static int minimumTotal(List<List<Integer>> triangle){
		Integer [] memo = triangle.get(triangle.size()-1).toArray(Integer[]::new);
		for(int i=triangle.size()-2;i>=0;i--){
			for(int j=0;j<triangle.get(i).size();j++){
				memo[j]=triangle.get(i).get(j)+Math.min(memo[j],memo[j+1]);
			}
		}
		return memo[0];
	}

}