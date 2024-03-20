def solution(friends, gifts):
    answer = 0
    
    present_give= {}
    present_take= {}
    res = {} # 선물 받을 수량
    for f in friends:
        present_give[f] = 0
        present_take[f] = 0
        res[f] = 0
        
    # 2차원 배열로 선물 준 횟수 기록
    arr = [[0 for j in range(len(friends))] for i in range(len(friends))]
    for g in gifts:
        
        sp = g.split()
        form = sp[0]
        to = sp[1]
        
        f_idx = friends.index(form)
        t_idx = friends.index(to)
        arr[f_idx][t_idx] += 1
        
        present_give[friends[f_idx]] += 1
        present_take[friends[t_idx]] += 1
    
    #print (arr)
    
    # 선물 지수 기록
    # 자신이 선물 준 횟수 - 자신이 선물 받은 횟수
    present = {}
    for f in friends:
        present[f] = present_give[f] - present_take[f]
    #print (present)            
    
    for i in range(len(friends)):
        for j in range(i+1, len(friends)):
            
            # i -> j 
            ip = arr[i][j]
            # j -> i
            jp = arr[j][i]
            
            if ip > jp:
                res[friends[i]] += 1
                            
            elif jp > ip:
                res[friends[j]] += 1                
                
            else:
                if present[friends[i]] > present[friends[j]]:
                    res[friends[i]] += 1
                    
                elif present[friends[j]] > present[friends[i]]:
                    res[friends[j]] += 1
                    
                else:
                    continue                        
    

    answer = max(res.values())    
    return answer