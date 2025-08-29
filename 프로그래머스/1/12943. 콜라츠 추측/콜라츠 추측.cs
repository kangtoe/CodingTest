using System;

public class Solution {
    
    long Col(long i)
    {
        if(i%2 ==0) i /= 2;
        else i = i * 3 +1;        
        return i;
    }
    
    public int solution(int num) {
        if(num ==1) return 0;
        
        int count = 0;
        long n = num;
        //Console.WriteLine(n.ToString());
        while(count < 500)
        {
            n = Col(n);
            count++;
            if(n==1) return count;            
        }
        
        return -1;
    }
}