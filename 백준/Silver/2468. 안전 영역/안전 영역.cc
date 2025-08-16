#include<iostream>
using namespace std;

int grid[101][101] = {};
int visited[101][101] = {};
int n;

void initArr()
{
	for (int i = 0; i < 101;i++)
	{
		for (int j = 0; j < 101;j++)
		{			
			visited[i][j] = 0;
		}
	}
}

void def(int x, int y, int h)
{
	visited[y][x] = 1;
	
	int dx[]={0,0,-1,1};
	int dy[]={1,-1,0,0};
	
	
	for(int i =0; i <4;i++)
	{
		int nx = x + dx[i];
		int ny = y + dy[i];
		
		if (nx < 0 || nx >= n || ny < 0 || ny >= n) continue;
		if (visited[ny][nx] != 0) continue;
		if (grid[ny][nx] <= h) continue;
			
		def(nx, ny, h);
	}
	
}

int main()
{	
	cin >> n;
	
	int max = 0;
	for(int i =0;i<n;i++)
	{
		for(int j =0;j<n;j++)	
		{
			int high;
			cin >> high;
			grid[i][j] = high;
			if (high > max) max = high;			
		}
	}
	
	int maxCount = 0;
	for(int h = 0; h < max; h++)
	{
		int count =0;
		initArr();
		
		for(int i =0;i<n;i++)
		{
			for(int j =0;j<n;j++)	
			{
				if (visited[i][j] != 0) continue;
				if (grid[i][j] <= h) continue;
				def(j,i,h);
				count ++;
			}
		}
		
		if (maxCount < count) maxCount = count;
	}
	
	cout << maxCount;
}