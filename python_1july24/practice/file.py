import os
f = open("demo.txt", "a") 
#print(f.read())
f.write("bsfkjhehrkhg")

f = open("demo.txt", "r") 
print(f.read())
f.close()

os.remove("demo.txt")