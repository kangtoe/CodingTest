#include <string>
#include <vector>
#include <set>

using namespace std;

vector<int> solution(vector<int> numbers) {
    set<int> s;
    
    for(int i = 0; i < numbers.size(); i++)
    {
        for(int j = 0; j < numbers.size(); j++)
        {
            if(i == j) continue;
            s.insert(numbers[i] + numbers[j]);
        }
    }        
    
    vector<int> answer;
    for(auto i : s)
    {
        answer.push_back(i);
    }    
    
    return answer;
}