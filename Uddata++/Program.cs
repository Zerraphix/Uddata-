using System;

namespace Uddata__
{
    class Program
    {
        static void Main(string[] args)
        {
            string coffeclub = "";
            Console.WriteLine("Hello World!");

            StudentClass student= new StudentClass();
            student.Name = "Joey";
            student.Warnings = 0;
            student.Subject = Subjects.Prog;
            student.Grade = (Grade)10;

            TeacherClass teacher = new TeacherClass();
            teacher.Name = "Henrik";
            teacher.CoffeeClub = true;
            teacher.Subject = Subjects.Prog;

            SubjectClass subject = new SubjectClass();
            subject.Name = "Programming";
            subject.Subject = Subjects.Prog;

            //foreach (var Grades in Enum.GetValues(typeof(Grade)))
            //{
            //    Console.WriteLine((int)Grades + " " + Grades.ToString());
            //}

            if (teacher.CoffeeClub == true) { coffeclub = " har et medlemskab til kaffeklubben"; }
            else { coffeclub = " har ikke et medlemskab til kaffeklubben"; }

            Console.WriteLine($"{student.Name} har {student.Subject} hvor han har fået {(int)student.Grade} en {student.Grade} karakter. Han har {student.Warnings} advarseler.");
            Console.WriteLine($"{teacher.Name} underviser i {teacher.Subject}. {teacher.Name}{coffeclub}");
            Console.WriteLine($"{subject.Subject} er en forkotelse for {subject.Name}");
        }
    }
}
