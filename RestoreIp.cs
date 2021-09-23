using System;
using System.Collections.Generic;
using System.Linq;

public class RestoreIp{
	static void Main(string [] args){
		
		string A = "25525511135";
		string B = "25505011535";
		Check(A);
	}
	static int is_Safe(string ip){
		IList<string> ips=new List<string>();
		string ex="";
		for(int i=0;i<ip.Length;i++){
			if(ip[i]=='.'){
				ips.Add(ex);
				ex="";
			}
			else{
				ex=ex+ip[i];	
			}
		}
		ips.Add(ex);
		
		for(int i=0;i<ips.Count;i++){
			if(int.Parse(ips[i])>255 ||int.Parse(ips[i])<0 || ips[i].Length>3 ) return 0;
			if(ips[i].Length >1 && int.Parse(ips[i])==0) return 0;
			if(ips[i].Length >1 && int.Parse(ips[i])!=0 && ips[i][0]=='0') return 0;
		}
		return 1;
	}
	static void Check(string ip){
		int length = ip.Length;
		if(length>12 || length<4){
			Console.WriteLine("NOt Valid");
		}
		IList<string> res = new List<string>();
		string check = ip;
		for(int i=1;i<length-2;i++){
			for(int j=i+1;j<length-1;j++){
				for(int k=j+1;k<length;k++){
					check = check.Substring(0,k)+"."+check.Substring(k);
					check=check.Substring(0,j)+"."+check.Substring(j);
					check=check.Substring(0,i)+"."+check.Substring(i);
					
					if(is_Safe(check)==1){
						res.Add(check);
						Console.WriteLine(check);
					}
					check = ip;
				}
			}
		}
		
	}
}