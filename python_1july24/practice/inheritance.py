class sound():
    def ___init__ (self,name):
        self.name=name
    def bark(self):
        print("ohh my good lg gai")     



class dog(sound):
    def __init__ (self, name,age):
        self.name=name
        self.age=age
    def bark(self):
        print("apne mom  dad ka tu hart na dukha ha=eart na dukha")    

newobj=dog("enaa",10)
newobj.bark()

        