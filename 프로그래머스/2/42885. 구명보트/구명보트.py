def solution(people, limit):
    people.sort()
    
    cnt = 0    
    start = 0
    end = len(people) - 1
    
    while start <= end:   
        #print(start, end)
        
        # 혼자 남겨진 경우
        if start == end:            
            cnt += 1
            break
        
        # 가장 무거운 사람이 누구와도 같이 탈 수 없는 경우
        if people[start] + people[end] > limit:            
            cnt += 1
            end -= 1
        else:
            cnt += 1
            end -= 1
            start += 1                    
                                                                             
    return cnt