#include <vector>
#include <algorithm>

using namespace std;

vector<int> solution(int n, long long left, long long right) {
    vector<int> answer;
    
    for(long long idx = left; idx <= right; idx++) {
        int row = idx / n;
        int col = idx % n;
        answer.push_back(max(row, col) + 1);
    }
    
    return answer;
}