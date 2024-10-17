using homework9._1;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter Student Name: ");
        string studentName = Console.ReadLine();

        Console.Write("Enter Student Age: ");
        int studentAge = int.Parse(Console.ReadLine());

        Console.Write("Enter Enrollment Year: ");
        int enrollmentYear = int.Parse(Console.ReadLine());

        Student student = new Student(studentName, studentAge, enrollmentYear);
        Console.WriteLine($"Student Name: {student.Name}, Age: {student.Age}, Enrollment Year: {student.EnrollmentYear}");
        Console.WriteLine($"Years until graduation: {student.YearsLeft()}");

        string randomsubject = student.RandomSubjects();
        Console.WriteLine($"Random Subject: {randomsubject}");

        Console.WriteLine();
        Console.WriteLine();
        
        // input for teacher

        Console.Write("Enter Teacher Name: ");
        string teacherName = Console.ReadLine();

        Console.Write("Is the Teacher Certified? (yes/no): ");
        bool isCertified = Console.ReadLine().Trim().ToLower() == "yes";

        Teacher teacher = new Teacher(teacherName, isCertified);

        Console.WriteLine($"{randomsubject} - {teacher.TeachSubject(randomsubject)}");



    }
}
