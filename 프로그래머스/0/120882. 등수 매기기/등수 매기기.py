def solution(score):    
    arr = [s[0] + s[1] for s in score]
    arr.sort(reverse = True)

    for i in range(len(score)):
        score[i] = arr.index(score[i][0] + score[i][1]) + 1
    return score