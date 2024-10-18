using System;

public class Person
{
    public string name { get; set; }
    public Person()
    {
        name = "Null";
    }

    public Person(string name)
        { 
        this.name = name; 
    }
}

public class Student:Person 
{
    public string regNo {  get; set; }
    public int age { get; set; }
    public Department program { get; set; }

    public Student():base()
    {
        regNo = "Null";
        age = 0;
       program = Department.Null;
    }

    public Student(string name,string regNo, int age, Department program):base(name)
    {
        this.regNo = regNo;
        this.age = age;
        this.program = program;
    }


}
public enum Department
{ 
    CS,CYS,SE,AF,AI,Null
}
class Program
{
    static void Main(string[] args)
    {
        Student student_1 = new Student();

        Console.WriteLine(" Default Values :");
        Console.WriteLine($" Name: {student_1.name}");
        Console.WriteLine($" RegNo: {student_1.regNo}");
        Console.WriteLine($" Age: {student_1.age}");
        Console.WriteLine($" Program: {student_1.program}");
        Console.WriteLine();


        Student student_2 = new Student("Muhammad Maaz","233553",19,Department.CS);

        Console.WriteLine(" Updated Values :");
        Console.WriteLine($" Name: {student_2.name}");
        Console.WriteLine($" RegNo: {student_2.regNo}");
        Console.WriteLine($" Age: {student_2.age}");
        Console.WriteLine($" Program: {student_2.program}");
    }
}