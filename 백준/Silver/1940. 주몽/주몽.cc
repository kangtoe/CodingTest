#include <vector>
#include <iostream>
#include <algorithm>
using namespace std;

int main()
{
	int n, m;
	cin >> n >> m;
	
	int arr[n];
	for(int i =0; i < n; i++)
	{
		cin >> arr[i];
	}
	
	int cnt = 0;
	for(int i =0; i < n - 1; i++)
	{
		for(int j = i + 1; j < n; j++)
		{
			if(arr[i] + arr[j] == m) cnt++;
		}
	}
	
	cout << cnt;
	
	return 0;
}