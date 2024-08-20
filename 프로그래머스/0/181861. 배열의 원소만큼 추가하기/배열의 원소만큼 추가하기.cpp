#include <string>
#include <vector>

using namespace std;

vector<int> solution(vector<int> arr) {
    vector<int> answer;
    
    for(int i = 0; i < arr.size(); i++)
    {
        int tmp = arr[i];
        for(int j = 0; j < tmp; j++) answer.push_back(tmp);
    }
    
    return answer;
}