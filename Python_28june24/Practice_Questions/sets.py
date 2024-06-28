
fruits = {"apple", "banana", "cherry"}


fruits.add("orange")
print("Set after adding orange:", fruits)


fruits.discard("banana")
print("Set after removing banana:", fruits)


has_apple = "apple" in fruits
print("Has apple:", has_apple)  


more_fruits = {"pear", "banana", "grape"}


union_fruits = fruits.union(more_fruits)
print("Union of sets:", union_fruits)


intersection_fruits = fruits.intersection(more_fruits)
print("Intersection of sets:", intersection_fruits)
