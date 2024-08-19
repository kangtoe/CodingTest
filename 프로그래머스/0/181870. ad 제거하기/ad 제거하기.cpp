#include <iostream>
#include <string>
#include <vector>

using namespace std;

vector<string> solution(vector<string> strArr) {
    vector<string> answer;
        
    int length = static_cast<int>(strArr.size());
    for (int i = 0; i < length; ++i) {
    
        string str = strArr[i];
        
        bool hasAd = false;
        char beforeC = ' ';
        for (char c : str) {
            if(beforeC == 'a' && c == 'd')
            {
                hasAd = true;
                break;
            }
            beforeC = c;
        }
        
        
        if(!hasAd)
        {
            cout << str << endl;
            answer.push_back(str);
        }
    }
    
    return answer;
}