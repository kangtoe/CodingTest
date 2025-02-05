#include <string>
#include <vector>
#include <algorithm>
#include <iostream>

using namespace std;

vector<int> solution(long long n) {
    auto s = to_string(n);
    reverse(s.begin(), s.end());
    
    vector<int> answer;
    for (char c : s)
    {
        int i = c - '0';
        answer.push_back(i);
    }
    
    return answer;
}