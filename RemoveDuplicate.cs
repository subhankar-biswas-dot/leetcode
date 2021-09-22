using System;
using System.Collections.Generic;
using System.Linq;

public class RemoveDuplicate{
	static void Main(string [] args){
		int [] data = new int[]{1,2,2};
		int i=0;		
		while(i<data.Length){
			int last=Array.LastIndexOf(data,data[i]);
			for(int j=i+2;j<=last;j++){
				data[j]=Int32.MaxValue;
			}
			i=last+1;
		}
		Array.Sort(data);
		int v = Array.IndexOf(data,Int32.MaxValue);
		//Console.WriteLine(v);
		var k = (data[data.Length-1]!=Int32.MaxValue)?data.Length:v;
		Console.WriteLine(k);
		Console.WriteLine(String.Join(",",data.Select(p=>p.ToString()).ToArray()));
	}
}