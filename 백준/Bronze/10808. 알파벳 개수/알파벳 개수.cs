using System;
class HelloWorld {

	static void Main() {
	    
	    int alp = 'z' - 'a' + 1;
		int[] arr = new int[alp];
		
		string str = Console.ReadLine();
		foreach(char c in str)
		{
		    arr[c-'a']++;
		}
		
		string ans = "";
		for(int i = 0; i < alp; i++)
		{
		    ans += arr[i];
		    if(i != alp - 1) ans += ' ';
		}
		
		Console.WriteLine(ans);
	}
}