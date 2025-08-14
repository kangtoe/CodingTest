#include <iostream>
#include <string>
using namespace std;


int main(){
	int count;
	cin >> count;
	
	// count first alp
	int arr['z'-'a'+1] = {0,};
	for(int i =0; i < count; i++)
	{
		string s;	
		cin >> s;
		arr[s[0]-'a']++;
	}
	
	// check alp count over 5
	string ans = "";
	for(int i = 0; i < 'z'-'a'+1; i++)
	{
		if(arr[i] >= 5) ans += 'a' + i;
	}
	
	if(ans == "") ans = "PREDAJA";
	cout << ans;
	
	return 0;
}