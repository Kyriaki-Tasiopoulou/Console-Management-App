using Microsoft.VisualBasic;
using PrivateSchool.Databases;
using PrivateSchool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.Repos
{
    internal class RepositoryUser
    {
        DatabaseUser db = new DatabaseUser();
        public void CreateCourse(Course course)
        {
            course.Id = db.Courses.Count == 0 ? 1 : db.Courses.Last().Id + 1;
            db.Courses.Add(course);
        }
        public List<Course> GetCourses()
        {
            return db.Courses;
        }
        public void CreateStudent(Student student)
        {
            student.Id = db.Students.Count == 0 ? 1 : db.Students.Last().Id + 1;

            db.Students.Add(student);
        }
        public List<Student> GetStudents()
        {
            return db.Students;
        }
        public void CreateTrainer(Trainer trainer)
        {
            trainer.Id = db.Trainers.Count == 0 ? 1 : db.Trainers.Last().Id + 1;
            db.Trainers.Add(trainer);
        }
        public List<Trainer> GetTrainers()
        {
            return db.Trainers;
        }
        public void CreateAssignment(Assignment assignment)
        {
            assignment.Id = db.Assignments.Count == 0 ? 1 : db.Assignments.Last().Id + 1;

            db.Assignments.Add(assignment);
        }
        public List<Assignment> GetAssignments()
        {
            return db.Assignments;
        }
        public void MatchStudentsPerCourse(Course course,Student student)
        {
            course.Students.Add(student);
        }
        public void MatchTrainersPerCourse(Course course,Trainer trainer)
        {
            course.Trainers.Add(trainer);
        }
        public void MatchAssignmentsPerCourse(Course course,Assignment assignment)
        {
            course.Assignments.Add(assignment);
        }
    }
}
