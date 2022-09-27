using PrivateSchool.Databases;
using PrivateSchool.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PrivateSchool
{
    internal class RepositorySynthetics
    {

        DatabaseSynthetics db = new DatabaseSynthetics();
        public List<Student> GetStudents()
        {
            return db.Students;
        }
        public List<Trainer> GetTrainers()
        {
            return db.Trainers;
        }
        public List<Assignment> GetAssignments()
        {
            return db.Assignments;
        }
        public List<Course> GetCourses()
        {
            return db.Courses;
        }
       
    }
}
