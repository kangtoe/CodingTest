def solution(dartResult):
    dartResult = list(dartResult)
    bounsCheck = ["S", "D", "T"]
    optionCheck = ["*", "#"]
    
    # 타입별 분리
    score = []
    bouns = []
    option = []            
    for i, dart in enumerate(dartResult):      
        # 점수
        if dart.isdigit():            
            if i > 0 and dartResult[i - 1].isdigit():
                score[-1] = 10
            else: score.append(int(dart))            
        # 보너스
        if dart in bounsCheck:
            bouns.append(dart)            
        # 옵션
        if i > 0 and dartResult[i - 1] in bounsCheck:
            if dart in optionCheck:
                option.append(dart)
            else: option.append("-")
        if dart in bounsCheck and i == len(dartResult) - 1:
            option.append("-")
    
    # 점수 리스트 구하기
    scoreArr = []
    for i in range(3):
        mult = bounsCheck.index(bouns[i]) + 1
        scoreArr.append(score[i] ** mult)
                
        if option[i] == "*":            
            scoreArr[-1] *= 2
            if i > 0:
                scoreArr[-2] *= 2
                
        if option[i] == "#":            
            scoreArr[-1] *= -1
    
    #print(scoreArr)
    return sum(scoreArr)
