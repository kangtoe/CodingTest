/******************************************************************************

                              Online C++ Compiler.
               Code, Compile, Run and Debug C++ program online.
Write your code in this editor and press "Run" button to compile and execute it.

*******************************************************************************/

#include <iostream>
#include <string>
#include <vector>
#include <algorithm>
using namespace std;

bool cmp(string a, string b)
{
    if(a.size()!=b.size()) return a.size()<b.size();
    else return a<b;
}

int main()
{
    int n;
    cin >> n; 
    
    vector<string> arr = {};
    for(int i = 0; i < n; i++)
    {
        string str = "";
        cin >> str;
        
        string tmp = "";
        for(char c : str)
        {
            if('0' <= c && c <= '9')
            {
                if(tmp=="0")tmp = "";
                tmp += c;
            }
            else if('a' <= c && c <= 'z')
            {
                if(tmp == "") continue;
                if(tmp[tmp.size()-1] == '0' && c == '0') continue;
                arr.push_back(tmp);
                tmp = "";
            }
            else
            {
                
            }
        }
        
        if(tmp == "") continue;
        arr.push_back(tmp);
    }
    
    sort(arr.begin(), arr.end(), cmp);
    
    //cout << "size " << arr.size() << endl;
    for(int i =0 ; i< arr.size(); i++)
    {
        cout << arr[i] << endl;
    }

    return 0;
}