#include <iostream>
#include <queue>
#include <string>
using namespace std;

int main (){
	int dx[] = {0,0,-1,1};
	int dy[] = {1,-1,0,0};
	
	int n, m;
	cin >> n >> m;	
	
	int maze[101][101] = {-1,};
	
	
	for(int i =0; i < n; i++)
	{
		string str;
		cin >> str;
		for(int j =0; j < m; j++)
		{
			maze[i][j] = str[j] - '0';
		}
	}
	
	int visited[101][101] = {-1};
	visited[0][0] = 1;
				
	queue<pair<int, int>> qu;
	qu.push({0,0});
	
	while(qu.size() != 0)
	{
		pair<int,int> e = qu.front();
		qu.pop();
		int x = e.first;
		int y = e.second;
		
		int nx, ny;
		for(int i = 0; i < 4; i++)
		{
			nx = x + dx[i];
			ny = y + dy[i];
			
			if(nx < 0 || nx >= m || ny < 0 || ny >= n) continue;
			if(visited[ny][nx] != 0) continue;
			if(maze[ny][nx] == 0) continue;
			visited[ny][nx] = visited[y][x] + 1;
			qu.push({nx,ny});
		}						
	}
	
	cout << visited[n-1][m-1];
	return 0;	
}