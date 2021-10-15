import java.util.*;
import java.io.*;
import  java.util.stream.*;
public class palindromPartition{
	public static void main(String [] args){
		String str = "aab";
		allCombination(str);
	}
	static void allCombination(String input){
		int n=input.length();
		List<List<String>> allpart = new ArrayList<>();
		Deque<String> curr = new LinkedList<>();
		allCombinationUtil(allpart,curr,0,n,input);
		System.out.println(allpart);

	}
	static void allCombinationUtil(List<List<String>> allPart,Deque<String> curr,int start,int end,String input){
		if(start>=end){
			allPart.add(new ArrayList<>(curr));
			return;
		}
		for(int i=start;i<end;i++){
			if(isPalindrom(input,start,i)){
				curr.addLast(input.substring(start,i+1));
				allCombinationUtil(allPart,curr,i+1,end,input);
				curr.removeLast();
			}
		}
	}
	static boolean isPalindrom(String str,int i,int j){
		if(i>j) return true;
		if(str.charAt(i)!=str.charAt(j)) return false;

		return isPalindrom(str,i+1,j-1);
	}
}