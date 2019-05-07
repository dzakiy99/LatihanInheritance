using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Anton";
            person.Age = 19;
            person.GetNameAndAge();

            Teacher teacher = new Teacher();
            teacher.Name = "Thomas";
            teacher.Age = 35;
            teacher.TeacherId = "2289";
            teacher.Subject = "Programming";
            teacher.GetNameAndAge();

            Student student = new Student();
            student.Name = "Abdul";
            student.Age = 19;
            student.StudentId = "1811";
            student.Email = "abdul2000@gmail.com";
            student.GetNameAndAge();

            Console.ReadKey();
        }
    }
}
