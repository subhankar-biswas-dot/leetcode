import java.util.*;
import java.lang.*;

public class surroundRegion{
	public static void main(String [] args){
		char [][] board={{'X','X','X','X'},{'X','O','O','X'},{'X','X','O','X'},{'X','O','X','X'}};
		for(int i=0;i<board.length;i++){
			for(int j=0;j<board[0].length;j++){
				if((i==0 || i==board.length-1 || j==0 || j==board[0].length-1) && board[i][j]=='O')
					dfs(i,j,board);
			}
		}
		for(int i=0;i<board.length;i++){
			for(int j=0;j<board[0].length;j++){
				if(board[i][j]=='O') board[i][j]='X';
			}
		}

	}
	static void dfs(int i,int j,char [][] board){
		if(i<0 || i>=board.length || j<0 || j>=board[0].length || board[i][j]!='O') return;
		if(board[i][j]=='O') board[i][j]='#';
		dfs(i+1,j,board);
		dfs(i,j+1,board);
		dfs(i-1,j,board);
		dfs(i,j-1,board);
	}

}