using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class WordSearch{
	 static void Main(string [] args){
	 	char [][] board = new char [][]{new char [] {'A','B','C','E'},new char [] {'S','F','C','S'},new char []{'A','D','E','E'}};
	 	string word = "SEE";
	 	Console.WriteLine(Exists(board,word));
	}
	static bool Exists(char [][] board,string word){
		int r = board.Length;
		int c = board[0].Length;
		int wlen = word.Length;
		
		for(int i=0;i<r;i++){
			for(int j=0;j<c;j++){
				if(helper(board,r,c,i,j,word,wlen,0))
					return true;
			}
		}

		return false;

	}
	static bool helper(char [][] board,int r,int c,int i,int j ,string word,int wlen,int index){
		if( index >=wlen || i>=r || j>=c|| i<0 || j<0 || word[index]!=board[i][j])
			return false;
		if(index == wlen-1)
			return true;

		board[i][j]='*';

		if(helper(board,r,c,i,j+1,word,wlen,index+1)) return true;
		if(helper(board,r,c,i+1,j,word,wlen,index+1)) return true;
		if(helper(board,r,c,i-1,j,word,wlen,index+1)) return true;
		if(helper(board,r,c,i,j-1,word,wlen,index+1)) return true;

		board[i][j]=word[index];

		return false;
		

	}
}