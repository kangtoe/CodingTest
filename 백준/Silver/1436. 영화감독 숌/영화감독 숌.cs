
using System;
class HelloWorld {
	static void Main() {
		int n = int.Parse(Console.ReadLine());
		int num = 0;
		
		for(int i = 0; i < n; i++)
		{
		    while(true)
		    {
		        num++;
		        if(num.ToString().Contains("666")) break;
		    }
		}
		
		Console.WriteLine(num);
	}
}