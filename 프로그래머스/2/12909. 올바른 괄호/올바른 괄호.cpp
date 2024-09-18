#include<string>
#include<vector>
#include <iostream>

using namespace std;

bool solution(string s)
{
    bool answer = true;
    string stack = "";
    
    for(char c : s)
    {
        if(c == ')' && stack.back() == '(') stack.pop_back();
        else stack += c;
    }
    
    return stack.size() == 0;
}