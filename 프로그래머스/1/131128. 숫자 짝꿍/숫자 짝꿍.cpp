#include <string>
#include <vector>
#include <algorithm>

using namespace std;

string solution(string X, string Y) {
    string answer = "";    
    
    vector<int> countX(10);
    vector<int> countY(10);
    vector<int> countXY(10);
    
    // 0 - 9 문자별 카운트
    for(char c : X)
    {
        int i = c - '0';
        countX[i]++;
    }
    for(char c : Y)
    {
        int i = c - '0';
        countY[i]++;
    }
        
    // 작은 카운트 수가 최대
    for(int i = 0; i < 10; i++)
    {
        countXY[i] = min(countX[i],countY[i]);
    }
    
    // 완전 불일치 검사
    int countSum = 0;
    for(int i : countXY) countSum += i;
    if(countSum == 0) return "-1";
    
    // 큰 수 * 카운트 수
    for(int i = 9; i >= 0; i--)
    {
        if(i == 0 && answer == "") return "0";
        for (int j = 0; j < countXY[i]; j++) answer += to_string (i);            
    }
    
    return answer;
}