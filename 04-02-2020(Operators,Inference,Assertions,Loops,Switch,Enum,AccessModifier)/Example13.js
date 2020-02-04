var Student = /** @class */ (function () {
    function Student(code, name) {
        this.studCode = 32;
        this.studName = 'Sneha';
    }
    Student.prototype.display = function () {
        return ("My unique code: " + this.studCode + ", my name: " + this.studName + ".");
    };
    return Student;
}());
var student = new Student(1, 'Shweta');
console.log(student.display());
