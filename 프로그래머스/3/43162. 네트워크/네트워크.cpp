#include <string>
#include <vector>

using namespace std;

bool dfs(int x, int y, vector<vector<int>> &computers, int n)
{   
    if(computers[x][y])
    {
        computers[x][y] = 0;
        for(int i = 0; i < n; i++) dfs(i, x, computers, n);        
        return true;
    }
    return false;
}

int solution(int n, vector<vector<int>> computers) {
    int count = 0;
    for(int i = 0; i < n; i ++)
    {
        for(int j = 0; j < n; j ++)
        {
            bool con = dfs(i, j, computers, n);
            if(con) count++;
        }
    }
    return count;
}