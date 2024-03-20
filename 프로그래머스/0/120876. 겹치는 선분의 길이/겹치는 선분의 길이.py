def solution(lines):
    answer = 0        
    overlapArr = []
    
    # 겹치는 구간 [시작, 끝]으로 나타내기
    for i in range(len(lines)):
        
        line1 = lines[i]        
        if i+1 == len(lines):
            line2 = lines[0]
        else:
            line2 = lines[i+1]
        
        if line1[1] > line2[0]:                        
            start = max(line2[0], line1[0])                        
            end = min(line1[1], line2[1])
            overlapArr.append([start, end])
    
    #print(overlapArr)
    
    overlap = []
    # 겹치는 구간 구하기
    for arr in overlapArr:
        for i in range(arr[0], arr[1]):
            overlap.append(i)
    
    overlap = set(overlap)
    print(overlap)
    
    return len(overlap)