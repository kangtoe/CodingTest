#include <string>
#include <vector>
#include <iostream>

using namespace std;

int solution(vector<vector<int>> board, int k) {
    int answer = 0;
    int len = board[0].size();
    
    for (int i = 0; i < board.size(); i++)
    {
        for(int j = 0; j < len; j++)
        {
            if (i+j<=k) answer += board[i][j];
            //cout << board[i][j] << ' ';
        }
        //cout << endl;
    }
        
    return answer;
}