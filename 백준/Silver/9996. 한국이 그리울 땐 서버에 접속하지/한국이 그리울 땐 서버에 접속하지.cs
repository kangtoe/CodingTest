using System;
class HelloWorld {
    
	static void Main() {
	    int n = int.Parse(Console.ReadLine());
		
		string str = Console.ReadLine();
		string front = "";
		string back =  "";
		
		int starIdx = -1;
		for(int i = 0; i< str.Length; i++)
		{
		    if(str[i]=='*')
		    {
		        starIdx = i;
		        break;
		    }
		    front += str[i];
		}
		for(int i = starIdx + 1; i < str.Length; i++)
		{
		    back += str[i];
		}
		
		for(int t = 0; t < n; t++)
		{
		    string word = Console.ReadLine();    
		    if(word.Length < front.Length + back.Length)
		    {
		        Console.WriteLine("NE");
		        continue;
		    }
		    
		    bool match = true;
		    for(int i = 0; i < front.Length; i++)
		    {
		        if(word[i] != front[i])
		        {
		            match = false;
		            break;
		        }
		    }
		    for(int i = 1; i <= back.Length; i++)
		    {
		        if(word[word.Length-i] != back[back.Length-i])
		        {
		            match = false;
		            break;
		        }
		    }
		    
		    if(match) Console.WriteLine("DA");
		    else Console.WriteLine("NE");
		}
		
	}
}