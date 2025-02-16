#include <string>
#include <vector>
#include <iostream>

using namespace std;

int solution(int n) {
    
    int a = 0;
    int b = 1;
    
    for(int i = 1; i < n; i++)
    {
        int tmp = a + b;
        a = b;
        b = tmp % 1234567;
    }    
        
    return b;
}