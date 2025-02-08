#include <string>
#include <vector>
#include <iostream>

using namespace std;

string solution(string s) {
        
    int i = s.size() / 2;    
        
    string ans = "";
    if(s.size()%2==0) ans += s[i-1];
    ans += s[i];
        
    return ans;
}