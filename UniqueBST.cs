using System;
using System.Collections.Generic;
using System.Linq;

public class UniqueBST {
    static void Main(string [] args){
        int n=18;
        int [] Table = new int[n+1];
        Table[0]=1;
        Table[1]=1;
        int nums = NumTreesDp(n,Table);
        Console.WriteLine(nums);        
    }
    //NonDp Solution
    static int NumTrees(int n) {
        if(n==0) return 1;
        int count =0;
        for(int i=1;i<=n;i++){
            count += NumTrees(i-1)*NumTrees(n-i);
        }
        return count;
    }
    //Dp Solution
    static int NumTreesDp(int n,int [] Table){
        if(Table[n]!=0) return Table[n];
        int count=0;
        for(int i=1;i<=n;i++){
            count+=NumTreesDp(i-1,Table)*NumTreesDp(n-i,Table);
            if(Table[i]==0){
                Table[i]=count;
            }
        }
        return Table[n];
    }
}