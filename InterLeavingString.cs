using System;
using System.Collections.Generic;
using System.Linq;

public class InterLeavingString{
	static void Main(string [] args){
		string A="aabcc";
		string B="dbbca";
		string C="aadbbcbcac";
		Console.WriteLine(isInterLeaving(A,B,C));
	}
	static bool isInterLeaving(string A,string B,string C){
		int M=A.Length;
		int N=B.Length;
		bool [,] table= new bool[M+1,N+1];
		if(M+N !=C.Length) return false;

		for(int i=0;i<=M;i++){
			for(int j=0;j<=N;j++){
				if(i==0 && j==0) table[i,j]=true;
				else if(i!=0 && A[i-1]==C[i+j-1])
					table[i,j]=table[i-1,j];
				else if(j!=0 && B[j-1]==C[i+j-1])
					table[i,j]=table[i,j-1];
				else if(i!=0 && j!=0 && A[i-1]==C[i+j-1] && B[j-1]==C[i+j-1])
					table[i,j]=(table[i-1,j] || table[i,j-1]);
			}
		}

		return table[M,N];
	}
}