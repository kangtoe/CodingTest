#include<iostream>
#include<vector>
#include<algorithm>
using namespace std;

int grid[101][101]={};
int visited[101][101]={};
int m, n, k;

int area;
vector<int> vec = {};

void dfs(int x, int y)
{
	visited[y][x] = 1;
	
	int dx[]={0,0,-1,1};
	int dy[]={1,-1,0,0};
	
	for (int i = 0; i <4;i++)
	{
		int nx = x + dx[i];
		int ny = y + dy[i];
		
		if(nx < 0 || ny < 0 || nx >= n || ny >= m) continue;
		if(visited[ny][nx]!=0) continue;
		if(grid[ny][nx]!=0)continue;
		
		area++;	
		dfs(nx, ny);
	}
}

int main()
{
	cin >> m>>n>>k;
	
	for(int i = 0; i < k;i++)
	{
		int minX, minY, maxX, maxY;
		cin >> minX >> minY >> maxX >> maxY;
		
		for(int j = minY; j < maxY; j++)
		{
			for(int l = minX; l < maxX; l++)
			{
				grid[j][l]++;				
			}
		}
	}
	
	int count =0;
	
	for(int i = 0; i< m; i++)
	{
		for(int j = 0; j< n; j++)
		{
			if(visited[i][j]!=0) continue;
			if(grid[i][j]!=0)continue;
			
			area = 1;
			count++;
			dfs(j,i);
			vec.push_back(area);			
		}				
	}
	
	cout << count << '\n';
	sort(vec.begin(),vec.end());
	for(int i = 0; i <count; i++)
	{
		cout << vec[i] << ' ';
	}
	return 0;
}