import sys
input = sys.stdin.readline

#print('n: ')
n = int(input())
for i in range(n):
        #print('a, b: ')
        a, b = map(int, input().split())
        print(a+b)