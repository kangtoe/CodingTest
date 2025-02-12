#include <string>
#include <vector>
#include <iostream>

using namespace std;

int takeout(vector<vector<int>> &board, int line)
{
    for(int i=0; i<board.size(); i++)
    {
        for (int j=0; j<board[i].size(); j++)
        {
            if(j!=line) continue;
            if(board[i][j]==0)continue;
            
            int tmp = board[i][j];
            board[i][j] = 0;
            return tmp;
        }                        
    }
    return 0; // 건질 게 없음
}

void debugBoard(vector<vector<int>> board)
{
    for(int i=0; i<board.size(); i++)
    {
        for (int j=0; j<board[i].size(); j++)
        {
            cout << board[i][j];
        }
        cout << endl;
    }
}

int solution(vector<vector<int>> board, vector<int> moves) {    
    vector<int> stack;
    int pop = 0;
    for(int i: moves)
    {
        int take = takeout(board, i-1);
        if(take == 0) continue;
        
        if (!stack.empty() && stack.back() == take)
        {
            stack.pop_back();
            pop++;
        }
        else
        {
            stack.push_back(take);
        }    
    }        
    
    return pop*2;
}