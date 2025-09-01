using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string myString) {
        List<String> answer = new List<String>();
        
        string str = "";
        foreach(char c in myString)
        {
            if(c == 'x')
            {
                if(str!="")answer.Add(str);
                str = "";
                continue;
            }
            
            str+=c;
        }
        
        if(str!="") answer.Add(str);
        answer.Sort();
        return answer.ToArray();
    }
}