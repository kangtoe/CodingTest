#include<iostream>
#include<string>
using namespace std;

char grid[101][101]={};
int wait[101][101]={};

int main()
{	

	int h, w;
	cin >> h >> w;
	for(int i =0; i < h; i++)
	{
		string str;
		cin >> str;
		for (int j = 0; j < w; j++)
		{
			grid[i][j] = str[j];
		}
	}
	
	for(int i =0; i < h; i++)
	{
		for (int j = 0; j < w; j++)
		{
			wait[i][j] = -1;
		}
	}
	
	for(int i =0; i < h; i++)
	{
		for (int j = 0; j < w; j++)
		{
			if(grid[i][j]!='c') continue;
			for(int k = j; k < w; k++)
			{
				int time = k-j;
				if(wait[i][k] == -1 || wait[i][k] > time) wait[i][k] = time;								
			}			
		}
	}
	
	for(int i =0; i < h; i++)
	{
		for (int j = 0; j < w; j++)
		{
			cout << wait[i][j];
			if(j+1!=w) cout << ' ';
		}
		if(i+1!=h) cout << endl;
	}
	
	return 0;
}