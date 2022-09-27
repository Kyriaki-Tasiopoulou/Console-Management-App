using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.Entities
{
    internal class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Fees { get; set; }

        //Navigation properties
        public List<Course> Courses { get; set; } = new List<Course>();

        public Student ()
	{

	}
        public Student(int id, string firstName, string lastName, DateTime dateOfBirth, int fees)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Fees = fees;

        }
    }
}
