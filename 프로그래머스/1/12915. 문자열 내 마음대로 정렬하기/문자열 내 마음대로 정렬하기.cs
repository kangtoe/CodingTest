using System;

public class Solution {
    public string[] solution(string[] strings, int n) {        
        Array.Sort(strings, (a,b)=>
        {                        
            int cmp = a[n].CompareTo(b[n]);
            if(cmp == 0) cmp = a.CompareTo(b);
            return cmp;
        });
        
        
        return strings;
    }
}