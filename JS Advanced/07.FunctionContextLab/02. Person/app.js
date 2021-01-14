class Person {
 
    constructor(firstName, lastName) {
 
        this.firstName = firstName;
        this.lastName = lastName;
    }
 
    get fullName() {
 
        return `${this.firstName} ${this.lastName}`;
    }
 
    set fullName(string) {
 
        let [firstName, lastName] = string.split(' ');
 
        if (!firstName || !lastName) return;
 
        this.firstName = firstName;
        this.lastName = lastName;
    }
 
    set setFirstName(name) {
 
        this.firstName = name;
    }
 
    set setLastName(name) {
 
        this.lastName = name;
    }
}