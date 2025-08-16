#include <iostream>
using namespace std;

int m, n, k;
int grid[51][51];
int visited[51][51];


void initArr()
{
	for(int i=0; i<51;i++)
	{
		for(int j=0; j<51;j++)
		{
			grid[j][i]=0;
			visited[j][i]=0;
		}		
	}
}

void dfs(int x, int y)
{
	int dx[] = {0,0,-1,1};
	int dy[] = {1,-1 ,0,0};
			
	for(int i =0; i< 4;i++)
	{
		int nx = x + dx[i];
		int ny = y + dy[i];
		
		if(nx < 0 || nx >= m || ny < 0 || ny >= n) continue;
		if(visited[ny][nx] != 0) continue;
		if(grid[ny][nx] != 1) continue;
		
		visited[ny][nx] = 1;
		dfs(nx, ny);
	}
}

int main()
{
	int t;
	cin >> t;
	
	for(int i = 0; i < t; i++)
	{
		initArr();			
		
		cin >> m >> n >> k;				
		
		for(int j = 0; j < k; j++)
		{
			int x, y;
			cin >> x >> y;
			grid[y][x] = 1;
		}
				
		int count = 0;
		for(int j=0;j<n;j++)
		{
			for(int l=0;l<m;l++)
			{
				if(visited[j][l] != 0) continue;
				if(grid[j][l] != 1) continue;
				
				visited[j][l] = 1;
				dfs(l, j);
				count++;
			}
		}
		
		cout << count << '\n';
	}	

	return 0;
}