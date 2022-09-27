using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.Entities
{
    internal class Trainer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }

        //Navigation properties
        public List<Course> Courses { get; set; } = new List<Course>();

        public Trainer ()
	{

	}
        public Trainer(int id, string firstName, string lastName, string subject)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
        }
    }
}
