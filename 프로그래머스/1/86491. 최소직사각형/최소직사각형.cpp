#include <string>
#include <vector>
#include <iostream>

using namespace std;

int getMax(vector<int> vec)
{
    int m = vec[0];
    for(int i = 0; i < vec.size(); i++)
    {
        if(vec[i] > m) m = vec[i];
    }
    return m;
}

int solution(vector<vector<int>> sizes) {
    int answer = 0;
    
    vector<int> mi;
    vector<int> mx;
    
    for (int i = 0; i < sizes.size(); i++)
    {
        int a,b;
        if(sizes[i][0] < sizes[i][1]){ a = sizes[i][0]; b = sizes[i][1];}
        else { b = sizes[i][0]; a = sizes[i][1];}        
        
        mi.push_back(a); 
        mx.push_back(b);
        
        cout << a << ' ' << b << endl;
    }        
    
    return getMax(mi) * getMax(mx);
}