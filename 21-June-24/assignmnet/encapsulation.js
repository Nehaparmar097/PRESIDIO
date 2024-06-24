class Student {
    constructor(name, age, studentID) {
        let _name = name;
        let _age = age;
        let _studentID = studentID;

        this.getName = () => _name;
        this.getAge = () => _age;
        this.getStudentID = () => _studentID;

        this.setName = (name) => _name = name;
        this.setAge = (age) => _age = age;
        this.setStudentID = (studentID) => _studentID = studentID;
    }

    getDetails() {
        return `Name: ${this.getName()}, Age: ${this.getAge()}, Student ID: ${this.getStudentID()}`;
    }
}

const student1 = new Student("Alice", 20, "S12345");
console.log(student1.getDetails()); // Output: Name: Alice, Age: 20, Student ID: S12345

// Trying to access the private variables directly will not work
console.log(student1._name); // Output: undefined

// Use the public methods to access and modify the private variables
student1.setName("Bob");
console.log(student1.getDetails()); // Output: Name: Bob, Age: 20, Student ID: S12345
