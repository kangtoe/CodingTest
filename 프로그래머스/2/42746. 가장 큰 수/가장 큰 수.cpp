#include <string>
#include <vector>
#include <algorithm>
#include <iostream>

using namespace std;

string solution(vector<int> numbers) {
    vector<string> svec;
    for(auto num : numbers) svec.push_back(to_string(num));
    
    sort(svec.begin(), svec.end(), [](string a, string b){
        return a+b > b+a;                
    });
    
    if(svec[0] == "0") return "0";
    
    string answer = "";
    for(auto s : svec) answer += s;    
    return answer;
}