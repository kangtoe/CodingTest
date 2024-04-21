def sol():
    s = input().upper()

    d = {}
    for c in s:
        if c in d:
            d[c] += 1
        else:
            d[c] = 1

    cnt = 0
    an = ' '
    for k, v in d.items():        
        if v > cnt:
            cnt = v
            an = k
        
    same = 0
    for v in d.values():
        if v == cnt:
            same += 1

        if same > 1:
            print('?')
            return

    print(an)
sol()
