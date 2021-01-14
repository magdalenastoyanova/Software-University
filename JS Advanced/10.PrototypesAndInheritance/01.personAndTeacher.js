function solve(){
class Person{
constructor(name, email){
    this.name = name;
    this.email = email;
}
}
class Teacher extends Person{
    constructor(name, email, subject){
   
        super(name, email);
    this.subject = subject;
    }
}
class Student extends Person, Teacher{
    constructor(name, email, subject, course){
        super(name, email, subject);
        this.course = course;
    }
     toStringExtension(){

        return `Person (name: ${this.name}, email: ${this.email})`;
        return `Student (name: ${this.name}, email: ${this.email}, course: ${this.course})`;
        return `Teacher (name: ${this.name}, email: ${this.email}, subject ${this.subject})`;
    }
}
return{
    Person,
    Teacher,
    Student
}
}