using System;

public class Professor
{
    public string ProfName { get; set; }
    public string ClassTeach { get; set; }
    private double salary;

    public Professor(string profName, string classTeach, double salary)
    {
        ProfName = profName;
        ClassTeach = classTeach;
        this.salary = salary;
    }

    public void SetSalary(double salaryAmount)
    {
        salary = salaryAmount;
    }

    public double GetSalary()
    {
        return salary;
    }
}

public class Student
{
    public string StudentName { get; set; }
    public string ClassEnroll { get; set; }
    private double studentGrade;

    public Student(string studentName, string classEnroll, double studentGrade)
    {
        StudentName = studentName;
        ClassEnroll = classEnroll;
        this.studentGrade = studentGrade;
    }

    public void SetGrade(double newGrade)
    {
        studentGrade = newGrade;
    }

    public double GetGrade()
    {
        return studentGrade;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Professor prof1 = new Professor("Alice", "Java", 9000);
        Console.WriteLine($"Professor {prof1.ProfName} teaches {prof1.ClassTeach} and has a salary of ${prof1.GetSalary()}.");

        Professor prof2 = new Professor("Bob", "Math", 8000);
        Console.WriteLine($"Professor {prof2.ProfName} teaches {prof2.ClassTeach} and has a salary of ${prof2.GetSalary()}.");

        double salaryDifference = prof1.GetSalary() - prof2.GetSalary();
        Console.WriteLine($"The difference in salary between {prof1.ProfName} and {prof2.ProfName} is ${salaryDifference}.");

        Student student1 = new Student("Lisa", "Java", 90);
        Console.WriteLine($"Student {student1.StudentName} is enrolled in {student1.ClassEnroll} and has a grade of {student1.GetGrade()}.");

        Student student2 = new Student("Tom", "Math", 80);
        Console.WriteLine($"Student {student2.StudentName} is enrolled in {student2.ClassEnroll} and has a grade of {student2.GetGrade()}.");

        double totalGradeJava = student1.GetGrade(); 
        double totalGradeMath = student2.GetGrade(); 
        double averageGrade = (totalGradeJava + totalGradeMath) / 2;
        Console.WriteLine($"The total grade of Lisa and Tom is {averageGrade}.");
    }
}
