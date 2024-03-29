def solution(bandage, health, attacks):    
    maxHealth = health
    bounsLeft = bandage[0]
    attackIdx = 0
    
    for time in range(attacks[-1][0] + 1):                
        if time == attacks[attackIdx][0]:  # 공격 검사          
            health -= attacks[attackIdx][1]
            attackIdx += 1
            bounsLeft = bandage[0]
            
            # 사망 체크
            if health <= 0:
                health = -1
                break
            
        else:
            health += bandage[1]
            bounsLeft -= 1
            
            if bounsLeft == 0: # 추가회복 검사
                health += bandage[2]
                bounsLeft = bandage[0] 
                
            health = min (health,maxHealth)
            
        print(time, health)
            
    return health