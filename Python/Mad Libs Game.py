
# ACC VR & AR Diploma
# Gerges Romany

import random

x = 0
def fan():
    while x < 1:
        friend = raw_input("Enter name your friend:  ")
        verb = raw_input("Enter verb:  ")
        place = raw_input("Enter place:  ")
        cartoon = raw_input("Enter Cartoon character:  ")
        y = [["One day I was sitting with my friend " , friend , " " , verb , " in the " , place , " and We made cartoon characters like " ,cartoon]
         ,["Please search with the police for a runaway fugitive named : " , friend , " The last time he was seen was " , verb , " in " , place ," with ", cartoon ]
          ,[""]
           ,[""] ]
        f = random.randint(0,1)
        l = "".join(y[f])
        print l
        print '\n' + '\n'
fan()
