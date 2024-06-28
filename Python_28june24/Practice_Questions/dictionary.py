
person = {
    "name": "Alice",
    "age": 30,
    "occupation": "Engineer"
}


print("Name:", person["name"])  


person["age"] = 31
person["city"] = "New York"
print("Updated person:", person)


for key, value in person.items():
    print(f"{key}: {value}")


if "age" in person:
    print("Age is in the dictionary")

