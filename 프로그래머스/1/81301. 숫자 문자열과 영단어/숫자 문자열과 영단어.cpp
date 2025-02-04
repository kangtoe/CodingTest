#include <string>
#include <vector>
#include <algorithm>
#include <map>
#include <iostream>

using namespace std;

int solution(string s) {
    map<string, string> numbers = {
        {"zero", "0"},
        {"one", "1"},
        {"two", "2"},
        {"three", "3"},
        {"four", "4"},
        {"five", "5"},
        {"six", "6"},
        {"seven", "7"},
        {"eight", "8"},
        {"nine", "9"}
    };

    string result = "";
    string stack = "";

    for (char c : s) {
        if (isdigit(c)) 
        {
            result += c;
        } 
        else 
        {
            stack += c;
            if (numbers.count(stack)) 
            {
                result += numbers[stack];
                stack = "";
            }
        }
    }

    return stoi(result);
}