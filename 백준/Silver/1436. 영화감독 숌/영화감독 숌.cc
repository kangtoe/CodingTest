# include <iostream>
# include <string>
using namespace std;

int main ()
{
	int n;
	cin >> n;
	
	int i = 666;
	int count = 0;
	while(true)
	{
		string str = to_string(i);
		if(str.find("666") != string::npos)
		{
			count++;			
		}
		if(count == n)
		{
			cout << str;
			break;
		}
		
		i++;
	}
	
	return 0;
}