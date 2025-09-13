
using System;
class HelloWorld {
    
    static long Go(long num, long mult, long mod)
    {
        if(mult == 1) return num % mod;
        
        long l = Go(num,mult/2,mod);
        l = (l * l) % mod;
        if(mult % 2 == 1)
        {
            l *= num;
            l %= mod;
        }
        
        return l;
    }
    
	static void Main() {
		
		string[] str = Console.ReadLine().Split();
		long a = long.Parse(str[0]);
		long b = long.Parse(str[1]);
		long c = long.Parse(str[2]);
		
		long ans = Go(a%c,b,c);
		
		Console.WriteLine(ans);
	}
}