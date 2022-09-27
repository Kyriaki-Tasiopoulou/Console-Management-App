using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool
{
    internal class ControllerSynthetic
    {
        RepositorySynthetics repo = new RepositorySynthetics();

        public void GetCourses()
        {
            var courses = repo.GetCourses();
            View.PrintAllCourses(courses);
        }
        public void GetStudents()
        {
            var students = repo.GetStudents();
            View.PrintAllStudents(students);
        }
        public void GetTrainers()
        {
            var trainers = repo.GetTrainers();
            View.PrintAllTrainers(trainers);
        }
        public void GetAssignments()
        {
            var assignments = repo.GetAssignments();
            View.PrintAllAssignmens(assignments);
        }
        public void GetStudentsPerCourse()
        {
            var courses = repo.GetCourses();
            View.PrintStudentsPerCourse(courses);
        }
        public void GetTrainersPerCourse()
        {
            var courses = repo.GetCourses();
            View.PrintTrainersPerCourse(courses);
        }
        public void GetAssignmentsPerCourse()
        {
            var courses = repo.GetCourses();
            View.PrintAssignmentsPerCourse(courses);
        }
        public void GetAssignmentsPerStudent()
        {
            var courses = repo.GetCourses();
            var students = repo.GetStudents();
            View.PrintAssignmentsPerStudent(courses, students);
        }
        public void GetStudentsWithMultiCourses()
        {
            var students = repo.GetStudents();
            View.PrintStudentsWithMultiCourses(students);
        }
    }
}

