def solution(quiz):
    answer = []
    
    for q in quiz:
        arr = q.split()
        print(arr)
        
        ans = ''
        a = int(arr[0])
        b = int(arr[2])
        c = int(arr[4])
        
        if(arr[1] == '-'):
            ans = (a - b == c)                        
        if(arr[1] == '+'):
            ans = (a + b == c)                        
            
        if ans:
            answer.append("O")
        else:
            answer.append("X")
    
    return answer