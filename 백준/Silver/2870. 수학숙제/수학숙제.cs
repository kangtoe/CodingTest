using System;
using System.Collections.Generic;
class HelloWorld {
	static void Main() {
		int n = int.Parse(Console.ReadLine());
		
		List<string> nums = new List<string>();
		for(int i =0; i < n;i++)
		{
		    string str = Console.ReadLine();
		    string numStr = "";
		    
		    foreach(char c in str)
		    {
		        if('0'<=c&&c<='9')
		        {
		            numStr+=c;
		        }
		        else
		        {
		            if(numStr=="")continue;
		            nums.Add(numStr);
		            numStr = "";
		        }
		    }
		    
		    if(numStr=="")continue;
            nums.Add(numStr);
            numStr = "";
		}
		
		for(int i = 0; i < nums.Count; i++)
		{
		    string str = nums[i];
		    for(int j = 0; j < str.Length; j++)
		    {
		        if(str[j]=='0'&&j!=str.Length-1)continue;
		        
		        string numStr = "";
		        for(int k = j; k < str.Length; k++)
		        {
		            numStr += str[k];
		        }
		        nums[i] = numStr;
		        break;
		    }
		}
		
		nums.Sort((a,b)=>{
		    int len = a.Length - b.Length;
		    if(len==0) return a.CompareTo(b);
		    return len;
		});
		foreach(string s in nums) Console.WriteLine(s);
	}
}