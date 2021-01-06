a, b, c, d = list(map(int, input().split()))
m = 0

#horas
if a < c:
    h = c - a
elif a > c:
    h = 24 - a + c
else:
    h = 24

if a == c:
    if b < d:
        m = d - b
        h = 0
    elif b > d:
        m = 60 - b + d
        h = 23    
else:
    if b < d:
        m = d - b
    elif b > d:
        h = h - 1
        m = (60 - b) + d        

print("O JOGO DUROU", h, "HORA(S) E", m, "MINUTO(S)")