#include <string>
#include <vector>
#include <algorithm>
#include <iostream>

using namespace std;


void printData(vector<vector<int>> data)
{
    for(auto d : data)
    {
        for(auto i : d)   
        {
            cout<< i<<" ";
        }
        cout << "" << endl;
    }
}

int solution(vector<vector<int>> data, int col, int row_begin, int row_end) {
    sort(data.begin(), data.end(), [&col](vector<int> a, vector<int> b){
        if(a[col-1] != b[col-1]) return a[col-1] < b[col-1];
        return a[0] > b[0];
    });
    
    int S_i = 0;
    for(int i = 0; i < data.size(); i++)
    {
        if(!(row_begin-1 <= i && i <= row_end-1)) continue;
        int tmp = 0;
        
        for(int j = 0; j < data[i].size(); j++) 
            tmp += data[i][j] % (i+1);
        
        S_i = tmp ^ S_i;
    }
    
    return S_i;
}