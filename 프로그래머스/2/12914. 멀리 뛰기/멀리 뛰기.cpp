#include <string>
#include <vector>
#include <iostream>

using namespace std;

long long solution(int n) {    
    // n번째 칸에 도달하기 위해서는 이전에 n-1 또는 n-2번째 칸에 있어야 한다.
    // a[n] = a[n-1] + a[n-2]
    
    vector<int> vec(n+1);
    vec[1] = 1;
    vec[2] = 2;    
    for(int i = 3; i <= n; i++)
    {
        vec[i] = (vec[i-1] + vec[i-2]) % 1234567;
        //cout << vec[i] << endl;
    }
    
    return vec[n];
}