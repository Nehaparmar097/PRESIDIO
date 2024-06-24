class Person {
    greet() {
        console.log("Hello, I am a person.");
    }
}

class Student extends Person {
    greet() {
        console.log("Hello, I am a student.");
    }
}

class Teacher extends Person {
    greet() {
        console.log("Hello, I am a teacher.");
    }
}

const people = [new Person(), new Student(), new Teacher()];
people.forEach(person => person.greet());

