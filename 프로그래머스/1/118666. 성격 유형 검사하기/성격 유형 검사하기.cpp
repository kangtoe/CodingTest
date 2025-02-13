#include <string>
#include <vector>
#include <map>
#include <iostream>

using namespace std;

char getC(map<char,int> m, char c1, char c2)
{
    if(m[c1] == m[c2]) return c1 < c2 ? c1 : c2;
    return  m[c1] > m[c2] ? c1 : c2;
}

string solution(vector<string> survey, vector<int> choices) {
    
    map<char,int> p;
    string str = "RTCFJMAN";
    for(char c : str)
    {        
        p.insert(make_pair(c, 0));
    }
    for(int i = 0; i < survey.size(); i++)
    {
        char c = survey[i][0];
        p[c]+=4-choices[i];
    }
            
    string answer = "";
    answer += getC(p, 'R','T');
    answer += getC(p, 'C','F');
    answer += getC(p, 'J','M');
    answer += getC(p, 'A','N');
    return answer;
}