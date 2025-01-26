#include <string>
#include <vector>

using namespace std;

bool canChange(string a, string b)
{
    int cnt = 0;
    for(int i = 0; i < a.size(); i++)
    {
        if(a[i]==b[i]) cnt++;
        if(cnt>1)return false;     
    }
    return true;
}

int solution(string begin, string target, vector<string> words) {
    
    int chanheCheck(){
        return 0
    }
    
    int answer = 0;
    return answer;
}