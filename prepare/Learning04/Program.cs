 using System;
 using System.Data.Common;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Student student = new Student("id2", "Professor Jane", "Bioagriculture");

//         Student.Display();
//         Faculty.Display();

//         List<Person> people = new List<Person>();
//         people.Add(student);
//         people.Add(Faculty);

//         foreach (Person person in people){

//         }
//     }
// }

// //Person
// class Person {
//     private string id;
//     private string name;

//     public Person(string id, string name){
//         this.id = id;
//         this.name = name;
//     }
// }

// // Student
// class Student: Person{
//     protected string major;
//     public Student(string id, string name, string major): base(id, name){ //base refers to parent class
//         this.major = major;
//     }
//     public void Display(){
//         Console.WriteLine('ID: {0}, Name: {1}, Major: {2}', id, name, major)
//     }
// }

// // Faculty
// class Faculty: Person{
//     private string department;
//     public Faculty(string id, string name, string department) :base(id, name){
//         this.department = department;
//     }
//     public void display(){
//         System.Console.WriteLine("ID: {0}, Name: {1}, Department: {2}", id ,name, major);
//     }
// }

class Program{

static void Main(string[] args){
Assignment myAssignment = new Assignment("sarah", "math");
Console.WriteLine(myAssignment.getSummary());
MathAssignment myMathAssignment = new MathAssignment("Allie", "Math", "7.3", "8-19");
Console.WriteLine(myMathAssignment.getHomeworkList());
Console.WriteLine(myMathAssignment.getSummary());
WritingAssignment myWritingAssignment = new WritingAssignment("James", "writing", "Causes of World War");
Console.WriteLine(myWritingAssignment.getWritingInformation());
}
}