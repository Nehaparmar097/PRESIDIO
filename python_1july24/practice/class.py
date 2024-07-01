class dog:
    def __init__ (self,name,age):
       self.name=name
       self.age=age
    def bark(self):
        print("i am barking")
d=dog("shanu",34)        
print(d.name)
d.bark()