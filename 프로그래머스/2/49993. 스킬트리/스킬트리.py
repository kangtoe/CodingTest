def check(tree, skill):
    tier = 0
    for t in tree:
        if not t == skill[tier]: return False
        tier += 1
    return True

def solution(skill, skill_trees):
    # 트리에 없는 스킬 제거
    for j, tree in enumerate(skill_trees):        
        arr = []
        for t in tree:
            if t in skill: 
                arr.append(t)   
        skill_trees[j] = "".join(arr)
        
    count = 0
    for tree in skill_trees:
        count += check(tree, skill)
        
    return count