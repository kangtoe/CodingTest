using System;
using System.Collections.Generic;

public class Solution {
    
    string GetStr(string my_string, int start)
    { 
        string str = "";
        for(int i = start; i < my_string.Length;i++)
        {
            str += my_string[i];
        }
        return str;
    }
    
    public string[] solution(string my_string) {
        List<string> answer = new List<string>();
        
        for(int i = 0; i < my_string.Length; i++)
        {
            string str = GetStr(my_string, i);
            answer.Add(str);
        }
        answer.Sort();
        
        return answer.ToArray();
    }
}