
# ACC VR & AR Diploma
# Gerges Romany

import time
num=1
x=1
while (num<=12):
    print "<--------- ",num," ----------->"
    while (x<=12):
        print num , "*" , x , "=" , (num*x)
        x=x+1
    num=num+1
    x=1
    print "\n"
time.sleep(500)
