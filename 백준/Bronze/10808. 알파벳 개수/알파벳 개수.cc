#include <iostream>
#include <algorithm>
#include <string>
using namespace std;

int main()
{	
	int cnt = 'z'-'a';
	int arr[cnt+1] = {0,};
	
	string str;
	cin >> str;
	
	for(char s : str)
	{
		arr[s-'a']++;
	}
	
	for(int i : arr)
	{		
		cout << i << ' ';
	}
	
	return 0;
}