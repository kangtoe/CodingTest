using System;
using System.Collections.Generic;
class HelloWorld 
{
    static bool IsM(char c)
    {
        char[] arr = new char[]{'a','i','u','e','o'};
        foreach(char alp in arr) if(c==alp) return true;
        return false;
    }
    
    static void PrintRes(string str, bool b)
    {
        string acc = b ? "acceptable" : "not acceptable";
        string res = "<"+str+"> is " + acc + ".";
        Console.WriteLine(res);
    }
    
    static bool Check(string str)
    {
        //check1
        bool inM = false;
        foreach(char c in str)
        {
            if(IsM(c))
            {
                inM = true;
                break;
            }
        }
        if(!inM)
        {
            return false;
        }
        
        //check3
        if(str.Length>=2)
        {
            for(int i = 1; i < str.Length; i++)
            {
                if(str[i] == str[i-1] && str[i] != 'e' && str[i] != 'o') return false;
            }
        }
        
        //check2
        if(str.Length>=3)
        {
            for(int i = 2; i < str.Length; i++)
            {
                if(IsM(str[i]) == IsM(str[i-1]) && IsM(str[i-1])== IsM(str[i-2])) return false;
            }
        }
        
        return true;
    }
    
	static void Main() 
	{
	    while(true)
	    {
	        string str = Console.ReadLine();
	        if(str == "end") break;
	        
	        bool b = Check(str);
	        PrintRes(str, b);
	    }
	    
	}
}