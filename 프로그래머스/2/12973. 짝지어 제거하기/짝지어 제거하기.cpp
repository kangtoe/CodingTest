#include <iostream>
#include<string>
using namespace std;

int solution(string s)
{
    string stack = "";    

    for (char c : s)
    {
        if( stack.back() == c)
        {
            stack.pop_back();
        }
        else
        {
            stack += c;
        }
    }
    
    return stack.empty();
}