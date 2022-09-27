using PrivateSchool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.Views
{
    internal class ViewForMatches
    {
        public static int GetCourseId(List<Course> courses)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Course Id    Course Title");
            Console.ResetColor();
            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Id,-10}{course.Title}");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Choose by Id the course to continue");
            Console.ResetColor();
            int courseId = Convert.ToInt32(Console.ReadLine());
            return courseId;
        }
        public static int GetStudentId(List<Student> students)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Student Id    Student Full Name");
            Console.ResetColor();
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Id,-10}{student.FirstName,-5}{student.LastName}");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Choose by Id the student you want to add in the choosen course");
            Console.ResetColor();
            int studentId = Convert.ToInt32(Console.ReadLine());
            return studentId;
        }
        public static int GetTrainerId(List<Trainer> trainers)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Trainer Id    Trainer Full Name");
            Console.ResetColor();
            foreach (var trainer in trainers)
            {
                Console.WriteLine($"{trainer.Id,-10}{trainer.FirstName,-5}{trainer.LastName}");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Choose by Id the trainer you want to add in the choosen course");
            Console.ResetColor();
            int trainerId = Convert.ToInt32(Console.ReadLine());
            return trainerId;
        }
        public static int GetAssignmentId(List<Assignment> assignments)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Assignment Id    Assignment Title");
            Console.ResetColor();
            foreach (var assignment in assignments)
            {
                Console.WriteLine($"{assignment.Id,10}{assignment.Title}");
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Choose by Id the assignment you want to add in the choosen course");
            Console.ResetColor();
            int studentId = Convert.ToInt32(Console.ReadLine());
            return studentId;
        }

    }
}
