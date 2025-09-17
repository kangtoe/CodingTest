using System;
using System.Collections.Generic;
class HelloWorld 
{
	static void Main() 
	{
	    Dictionary<int,int> countDict = new Dictionary<int,int>();
	    Dictionary<int,int> firstDict = new Dictionary<int,int>();
	    
	    string[] nc = Console.ReadLine().Split();
	    int n= int.Parse(nc[0]);
	    int c= int.Parse(nc[1]);
	    
	    string[] strs = Console.ReadLine().Split();
	    for(int i = 0; i < n; i++)
	    {
	        int num = int.Parse(strs[i]);
	        
	        if(countDict.ContainsKey(num)) countDict[num]++;
	        else countDict.Add(num, 1);
	        
	        if(!firstDict.ContainsKey(num)) firstDict.Add(num, i);
	    }
	    
	    List<List<int>> arr = new List<List<int>>();
	    foreach(int key in countDict.Keys)
	    {
	        List<int> li = new List<int>();
	        li.Add(key);
	        li.Add(countDict[key]);
	        li.Add(firstDict[key]);
	        arr.Add(li);
	    }
	    
	    arr.Sort((a,b) =>{
	        int count = b[1] - a[1];
	        if(count == 0) return a[2] - b[2];
	        return count;
	    });
	    
	    List<int> ans = new List<int>();
	    for(int i = 0; i < arr.Count; i++)
	    {
	        for(int j = 0; j < arr[i][1]; j++)
	        {
	            ans.Add(arr[i][0]);
	        }
	    }
	    
	    string s = string.Join(" ", ans);
	    Console.Write(s);
	}
}