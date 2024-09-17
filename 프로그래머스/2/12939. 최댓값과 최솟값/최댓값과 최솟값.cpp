#include <string>
#include <vector>
#include <iostream>
#include <algorithm>

using namespace std;
string solution(string s) {
    
    string stack;
    vector<int> nums;        
    for(char c : s)
    {
        if (c == ' ') // split string
        {
            int num = stoi(stack);
            nums.push_back(num);
            stack = "";
        }
        else
        {
            stack += c;
        }                        
    }
    // 마지막 문자 처리
    int num = stoi(stack);
    nums.push_back(num);
        
    int min;
    int max;        
    
    // min, max
    max = *max_element(nums.begin(), nums.end());
    min = *min_element(nums.begin(), nums.end());
    
    //cout << min << " " << max << '\n';
    return to_string(min) + " " + to_string(max);
}