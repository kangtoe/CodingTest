#include <iostream>
#include <string>
#include <vector>
#include <cmath>

using namespace std;

int getDivisor(int num)
{
    int count = 0;
    for(int i = 1; i <= pow(num, 0.5); i++)
    {
        if(i * i == num) count+=1;
        else if(num % i == 0)  count+=2;
    }
    return count;
}

int solution(int number, int limit, int power) {
            
    int iron = 0;    
    for(int i = 1; i <= number; i++)
    {
        int atk = getDivisor(i);
        if (atk > limit) atk = power;    
        iron += atk;        
    }
    
    return iron;
}