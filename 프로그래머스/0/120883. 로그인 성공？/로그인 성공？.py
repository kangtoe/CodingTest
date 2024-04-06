def solution(id_pw, db):
    
    for data in db:
        idC = data [0] == id_pw[0]
        pwC = data [1] == id_pw[1]
        
        if idC and pwC:
            return "login"
        
        if idC:
            return "wrong pw"
            
    return "fail"