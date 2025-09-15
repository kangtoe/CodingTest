using System;
class HelloWorld {
    
    static char Change(char c)
    {
        if(c==' ') return ' ';
        
        if('a' <= c && c <= 'z')
        {
            if(c + 13 > 'z')
            {
                return (char)(c +'a' -'z' +13 - 1);
            }
            return (char)(c + 13);
        }
        
        if('A' <= c && c <= 'Z')
        {
            if(c + 13 > 'Z')
            {
                return (char)(c +'A' - 'Z' + 13 -1);
            }
            return (char)(c + 13);
        }
        
        return c;
    }
    
	static void Main() {
		string str = Console.ReadLine();
		
		string ans = "";
		foreach(char c in str)
		{
		    ans += Change(c);
		    //Console.WriteLine(Change(c));
		}
		
		Console.WriteLine(ans);
		//Console.WriteLine(Change('o'));
	}
}