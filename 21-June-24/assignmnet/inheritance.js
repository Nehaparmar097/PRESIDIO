
function Person(name, age) {
    this.name = name;
    this.age = age;
}

Person.prototype.getDetails = function() {
    return `Name: ${this.name}, Age: ${this.age}`;
};

function Student(name, age, studentID) {
    Person.call(this, name, age);
    this.studentID = studentID;
}

Student.prototype = Object.create(Person.prototype);
Student.prototype.constructor = Student;

Student.prototype.getStudentID = function() {
    return `Student ID: ${this.studentID}`;
};

const student1 = new Student("Alice", 20, "S12345");
console.log(student1.getDetails()); // Output: Name: Alice, Age: 20
console.log(student1.getStudentID()); // Output: Student ID: S12345
