/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
    
    static int[] score = new int[3];
	static int[] winTime = new int[3];
	
	static int ToSec(string time)
	{
	    string minStr = "" + time[0] + time[1];
	    string secStr = "" + time[3] + time[4];
	    
	    int min = int.Parse(minStr);
	    int sec = int.Parse(secStr);
	    
	    return min * 60 + sec;
	}
	
	static string ToStr(int time_sec)
	{
	    int min = time_sec / 60;
	    int sec = time_sec % 60;
	    
	    string minStr = min >= 10 ? min.ToString() : "0" + min;
	    string secStr = sec >= 10 ? sec.ToString() : "0" + sec;
	    
	    return minStr + ":" + secStr;
	}
    
	static void Main() {
	    int n = int.Parse(Console.ReadLine());
	    
	    int beforeTime = 0;
	    for(int i = 0; i < n; i++)
	    {
	        string[] str = Console.ReadLine().Split();
	        int team = int.Parse(str[0]);
	        int time = ToSec(str[1]);
	        
	        int duration = time - beforeTime;
	        beforeTime = time;
	        
            if(score[1]>score[2]) winTime[1] += duration;
            if(score[2]>score[1]) winTime[2] += duration;
            score[team]++;

	    }
	    
	    int remainTime = 48 * 60 - beforeTime;
        if(score[1]>score[2]) winTime[1] += remainTime;
        if(score[2]>score[1]) winTime[2] += remainTime;
	    
		Console.WriteLine(ToStr(winTime[1]));
		Console.WriteLine(ToStr(winTime[2]));
	}
}