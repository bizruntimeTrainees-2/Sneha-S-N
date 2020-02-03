var Student = /** @class */ (function () {
    function Student(RollNo, Name) {
        this.RollNo = RollNo;
        this.Name = Name;
    }
    Student.prototype.showDetails = function () {
        console.log(this.RollNo + " : " + this.Name);
    };
    return Student;
}());
