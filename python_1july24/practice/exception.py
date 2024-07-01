try:
    num=10/0
except ZeroDivisionError:
     print("cannot be divided by zeroo")   

try:
     num=10/q
 
except  TypeError as e:
     print("111111111111111111111111cant notbe diivded by alphbet")   
except  NameError as e:
     print("22222222222222222222222222222cant notbe diivded by alphbet")
except  Exception as e:
     print(f"cant notbe diivded by alphbet +{e}")   
   
