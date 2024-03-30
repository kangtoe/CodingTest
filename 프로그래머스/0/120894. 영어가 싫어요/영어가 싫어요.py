def solution(numbers):
    answerStr = ''
    arr =["zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"]
    stack = ''
    
    
    for s in numbers:
        stack += s
        
        for i in range(len(arr)):
            if stack == arr[i]:
                answerStr += str(i)
                stack = ""
                break            
    
    return int(answerStr)