using System;

public class Solution {
    public int solution(string my_string, string is_prefix) {
        
        if(my_string.Length < is_prefix.Length) return 0;
        for(int i = 0; i < is_prefix.Length; i++)
        {
            if( is_prefix[i] != my_string[i]) return 0;
        }
        
        return 1;
    }
}