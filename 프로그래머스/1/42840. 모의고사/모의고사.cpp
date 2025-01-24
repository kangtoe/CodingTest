#include <string>
#include <vector>

using namespace std;

vector<int> solution(vector<int> answers) {    
    vector<int> ans1 = {1, 2, 3, 4, 5};
    vector<int> ans2 = {2, 1, 2, 3, 2, 4, 2, 5};
    vector<int> ans3 = {3, 3, 1, 1, 2, 2, 4, 4, 5, 5};
    int score1 = 0;
    int score2 = 0;
    int score3 = 0;
    
    for(int i = 0; i < answers.size(); i++)
    {
        if(answers[i] == ans1[i%ans1.size()]) score1++;
        if(answers[i] == ans2[i%ans2.size()]) score2++;
        if(answers[i] == ans3[i%ans3.size()]) score3++;
    }
    
    int m = max(score1, max(score2, score3));
    
    vector<int> answer;
    if(score1 == m) answer.push_back(1);
    if(score2 == m) answer.push_back(2);
    if(score3 == m) answer.push_back(3); 
        
    return answer;
}