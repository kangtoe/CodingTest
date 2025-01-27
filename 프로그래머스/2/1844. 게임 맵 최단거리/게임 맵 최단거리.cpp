#include<vector>
#include <deque>
using namespace std;

int bfs(vector<vector<int> > maps, int startX, int startY)
{
    vector<int> dx = {-1,1,0,0};
    vector<int> dy = {0,0,1,-1};
    
    int n = maps.size();
    int m = maps[0].size();
    
    deque<int> dqX, dqY;
    dqX.push_back(startX);
    dqY.push_back(startY);
    
    while(dqX.size() > 0)
    {
        int x = dqX.front(); 
        int y = dqY.front();
        dqX.pop_front();
        dqY.pop_front();
        
        for(int i = 0; i< 4; i++)
        {
            int nx = x + dx[i];
            int ny = y + dy[i];
            
            if(nx == startX && ny == startY) continue;
            if( nx < 0 || nx >= n || ny < 0 || ny >= m) continue;
            if(maps[nx][ny] == 0) continue;
            
            if(maps[nx][ny] == 1)
            {
                maps[nx][ny] = maps[x][y] + 1;
                dqX.push_back(nx);
                dqY.push_back(ny);
            }
        }        
    }
    
    int goal = maps[n-1][m-1];
    if(goal != 1) return goal;
    else return -1;    
}

int solution(vector<vector<int> > maps)
{
    return bfs(maps, 0,0);
}