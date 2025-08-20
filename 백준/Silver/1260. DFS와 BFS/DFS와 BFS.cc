# include <iostream>
# include <vector>
# include <queue>
# include <algorithm>
using namespace std;

int n, m, v;

vector<vector<int>> vec = {};

void initVec()
{
	for(int i =0; i < 1002; i++)
	{
		vector<int> e = {};
		vec.push_back(e);
	}
}

int visitedDfs[1002] = {};
int visitedBfs[1002] = {};

vector<int> dfsRes = {};
vector<int> bfsRes = {};

void printVec(vector<vector<int>> vec)
{
	cout << endl << "print vec" << endl;
	for (int i = 0; i < vec.size(); i++)
	{
		if(vec[i].size() == 0) continue;
		cout << "i " << i << " : ";
		for (int j = 0; j < vec[i].size(); j++)
		{
			cout << vec[i][j] << " ";
		}
		cout << endl;
	}
	cout << endl;
}

void dfs(int index)
{	
	dfsRes.push_back(index);
	visitedDfs[index] = 1;
	
	int size = vec[index].size();
	for(int i = 0; i < size; i++)
	{
		int e = vec[index][i];
		if(visitedDfs[e] != 0) continue;
						
		dfs(e);
	}
}

void bfs(int index)
{		
	queue<int> q;
	
	q.push(index);		
	visitedBfs[index] = 1;			
			
	while(q.size() > 0)
	{
		int t = q.front();
		q.pop();
		bfsRes.push_back(t);
		
		for(int i = 0; i < vec[t].size(); i++)
		{			
			int e = vec[t][i];
			if(visitedBfs[e] != 0) continue;
			
			q.push(e);			
			visitedBfs[e] = 1;			
		}
	}
}

int main()
{	
	initVec();
	
	cin >> n >> m >> v;	
	for (int i = 0; i< m; i++)
	{
		int a, b;
		cin >> a >> b;
		vec[a].push_back(b);
		vec[b].push_back(a);
	}
	
	for(int i = 0; i < vec.size(); i++)
	{
		sort(vec[i].begin(), vec[i].end());
	}
	
	//printVec(vec);

	dfs(v);
	for(int i = 0; i < dfsRes.size(); i++)
	{
		cout << dfsRes[i];
		if(i!=dfsRes.size()-1) cout << ' ';
	}
	cout << endl;
		
	bfs(v);
	for(int i = 0; i < bfsRes.size(); i++)
	{
		cout << bfsRes[i];
		if(i!=bfsRes.size()-1) cout << ' ';
	}
	
	return 0;
}