using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        string str = n.ToString();
        foreach (char c in str)
        {
            int i = c - '0';
            answer += i;
        }        
        
        return answer;
    }
}