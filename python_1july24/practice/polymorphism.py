#making twoo diff clases
class parent:
    def makesound(self):
        pass
class one(parent):
    def makesound(self):
        print("one one one")
class second(parent):
    def makesound(self):
        print("second second")
def allsound(parent):
    parent.makesound()
    
newone=one()
newsecond=second()
allsound(newone)
print("---------====--------------------")
allsound(newsecond)