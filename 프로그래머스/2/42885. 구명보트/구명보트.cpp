#include <string>
#include <vector>
#include <algorithm>
#include <iostream>

using namespace std;

int solution(vector<int> people, int limit) {
    sort(people.begin(), people.end());    
    
    int count = 0;
    int head = 0, tail = people.size() - 1;
    while(head <= tail)
    {        
        
        if(head == tail)
        {
            count += 1;
            break;
        }
        if(people[head] + people[tail] > limit)
        {
            count++;
            tail--;
            continue;
        }
        head++;
        tail--;
        count++;
    }
        
    return count;
}