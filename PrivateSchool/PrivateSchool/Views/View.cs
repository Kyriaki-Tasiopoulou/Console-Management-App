using PrivateSchool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{
    internal class View
    {
        public static void PrintAllStudents(List<Student> students)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----- ALL STUDENTS -----");
            Console.WriteLine();
            Console.WriteLine($"{"STUDENT'S FULL NAME",-10}");
            Console.ResetColor();
            Console.WriteLine();
            foreach (var student in students)
            {
                Console.WriteLine($"{student.FirstName,-10}{student.LastName}");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("-------------------------");
                Console.ResetColor();
                Console.WriteLine();
            }
        }
        public static void PrintAllTrainers(List<Trainer> trainers)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----- ALL TRAINERS -----");
            Console.WriteLine();
            Console.WriteLine($"{"TRAINER'S FULL NAME",-10}");
            Console.ResetColor();
            Console.WriteLine();
            foreach (var trainer in trainers)
            {
                Console.WriteLine($"{trainer.FirstName,-10}{trainer.LastName}");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("-------------------------");
                Console.ResetColor();
                Console.WriteLine();
            }
        }
        public static void PrintAllAssignmens(List<Assignment> assignments)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----- ALL ASSIGNMENTS -----");
            Console.WriteLine();
            Console.WriteLine("ASSIGNMENT'S TITLE");
            Console.ResetColor();
            Console.WriteLine();
            foreach (var assignment in assignments)
            {
                Console.WriteLine(assignment.Title);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("------------------");
                Console.ResetColor();
            }
        }
        public static void PrintAllCourses(List<Course> courses)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----- ALL COURSES -----");
            Console.WriteLine();
            Console.WriteLine("COURSE'S TITLE");
            Console.ResetColor();
            Console.WriteLine();
            foreach (var course in courses)
            {
                Console.WriteLine(course.Title);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("------");
                Console.ResetColor();
            }
        }
        public static void PrintStudentsPerCourse(List<Course> courses)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----- STUDENTS PER COURSE -----");
            Console.ResetColor();
            foreach (var course in courses)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("COURSE");
                Console.ResetColor();
                Console.WriteLine($"{course.Title,-10}{course.Type}");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{"STUDENT'S FULL NAME",-10}");
                Console.ResetColor();
                foreach (var student in course.Students)
                {
                    Console.WriteLine($"{student.FirstName,-10}{student.LastName}");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("-------------------------");
                    Console.ResetColor();
                    Console.WriteLine();
                }
            }
        }
        public static void PrintTrainersPerCourse(List<Course> courses)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----- TRAINERS PER COURSE -----");
            Console.ResetColor();
            foreach (var course in courses)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("COURSE");
                Console.ResetColor();
                Console.WriteLine($"{course.Title,-10}{course.Type}");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{"TRAINER'S FULL NAME",-10}");
                Console.ResetColor();
                foreach (var trainer in course.Trainers)
                {
                    Console.WriteLine($"{trainer.FirstName,-10}{trainer.LastName}");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("-------------------------");
                    Console.ResetColor();
                    Console.WriteLine();
                }
            }
        }
        public static void PrintAssignmentsPerCourse(List<Course> courses)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----- ASSIGNMENTS PER COURSE -----");
            Console.ResetColor();
            foreach (var course in courses)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("COURSE");
                Console.ResetColor();
                Console.WriteLine($"{course.Title,-10}{course.Type}");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("ASSIGNMENTS");
                Console.ResetColor();
                foreach (var assignment in course.Assignments)
                {
                    Console.WriteLine($"{assignment.Title,-10}");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("---------------------");
                    Console.ResetColor();
                }
            }
        }
        public static void PrintAssignmentsPerStudent(List<Course> courses, List<Student> students)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----- ASSIGNMENTS PER STUDENT -----");
            Console.WriteLine();
            Console.ResetColor();
            foreach (var student in students)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("STUDENT'S FULL NAME");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine($"{student.FirstName,-10}{student.LastName}");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("ASSIGNMENT'S TITLE");
                Console.ResetColor();
                foreach (var course in student.Courses)
                {
                    foreach (var assignment in course.Assignments)
                    {
                        Console.WriteLine(assignment.Title);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("------------------");
                        Console.ResetColor();
                    }
                }
            }
        }
        public static void PrintStudentsWithMultiCourses(List<Student> students)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("----- STUDENTS WITH MULTI COURSES -----");
            Console.WriteLine();
            Console.WriteLine("STUDENTS FULL NAME");
            Console.WriteLine();
            Console.ResetColor();
            foreach (var student in students)
            {
                if (student.Courses.Count > 1)
                {
                    Console.WriteLine($"{student.FirstName,-10}{student.LastName}");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("-------------------");
                    Console.ResetColor();
                }

            }

        }
        
    }
}
