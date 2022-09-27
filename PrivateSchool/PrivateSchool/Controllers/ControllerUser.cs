using PrivateSchool.Entities;
using PrivateSchool.Repos;
using PrivateSchool.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.Controllers
{
    internal class ControllerUser
    {
        RepositoryUser repo = new RepositoryUser();
        public void CreateCourse()
        {
            Course course = ViewForCreate.CreateCourse();
            repo.CreateCourse(course);
        }
        public void GetCourses()
        {
            var courses = repo.GetCourses();
            View.PrintAllCourses(courses);
        }

        public void CreateStudent()
        {
            Student student = ViewForCreate.CreateStudent();
            repo.CreateStudent(student);
        }
        public void GetStudents()
        {
            var students = repo.GetStudents();
            View.PrintAllStudents(students);
        }
        public void CreateTrainer()
        {
            Trainer trainer = ViewForCreate.CreateTrainer();
            repo.CreateTrainer(trainer);
        }
        public void GetTrainers()
        {
            var trainers = repo.GetTrainers();
            View.PrintAllTrainers(trainers);
        }
        public void CreateAssignment()
        {
            Assignment assignment = ViewForCreate.CreateAssignment();
            repo.CreateAssignment(assignment);
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
        public void MatchStudentsPerCourse()
        {
            var courses = repo.GetCourses();
            var students = repo.GetStudents();
            int courseId = ViewForMatches.GetCourseId(courses);
            int studentId = ViewForMatches.GetStudentId(students);
            Course courseToMatch = courses.Find(x => x.Id == courseId);
            Student studentToMatch = students.Find(x => x.Id == studentId);
            repo.MatchStudentsPerCourse(courseToMatch,studentToMatch);
        }
        public void MatchTrainersPerCourse()
        {
            var courses = repo.GetCourses();
            var trainers = repo.GetTrainers();
            int courseId = ViewForMatches.GetCourseId(courses);
            int trainerId = ViewForMatches.GetTrainerId(trainers);
            Course courseToMatch = courses.Find(x => x.Id == courseId);
            Trainer trainerToMatch = trainers.Find(x => x.Id == trainerId);
            repo.MatchTrainersPerCourse(courseToMatch,trainerToMatch);
        }
        public void MatchAssignmentsPerCourse()
        {
            var courses = repo.GetCourses();
            var assignments = repo.GetAssignments();
            int courseId = ViewForMatches.GetCourseId(courses);
            int assignmentId = ViewForMatches.GetAssignmentId(assignments);
            Course courseToMatch = courses.Find(x => x.Id == courseId);
            Assignment assignmentToMatch = assignments.Find(x => x.Id == assignmentId);
            repo.MatchAssignmentsPerCourse(courseToMatch,assignmentToMatch);    
        }

    }
}
