using System;
class HelloWorld {
	static void Main() {
		int[] alps = new int[51];
		
		string str = Console.ReadLine();
		for(int i = 0; i < str.Length; i++)
		{
		    int idx = str[i] - 'A';
		    alps[idx]++;
		}
		
		
		bool odd = false;
		char c = ' ';
		for(int i = 0 ; i< alps.Length; i++)
		{
		    if(alps[i]%2==1)
		    {
		        if(odd) 
		        {
		            Console.WriteLine("I'm Sorry Hansoo");
		            return;
		        }
		        else
		        {
		            odd = true;
		        }
		    }
		}
		
		
		string head = "";
		string tail = "";
		for(int i = 0 ; i< alps.Length; i++)
		{
		    if(alps[i]%2==1)
		    {
		        c = (char)('A' + i);
		        alps[i]--;
		    }
		    
		    for(int j = 0; j < alps[i]/2; j++)
		    {
		        head += (char)('A' + i);
		    }
		}
		
		for(int i = head.Length-1 ; i >= 0; i--)
		{
		    tail += head[i];
		}
		
		string ans;
		if(c != ' ') ans = head+c+tail;
		else ans = head+tail;
		Console.WriteLine(ans);
	}
}