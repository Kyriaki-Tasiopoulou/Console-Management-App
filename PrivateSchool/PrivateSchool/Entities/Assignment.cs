using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.Entities
{
    internal class Assignment
    {
        public int Id { get; set; } 
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime SubDateTime { get; set; }
        public int OralMark { get; set; }
        public int TotalMark { get; set; }

        //Navigation properties
        public Course Cource { get; set; } 
        public Assignment ()
	{

	}
        public Assignment(int id, string title, string description, DateTime subDateTime, int oralMark, int totalMark)
        {
            Id = id;
            Title = title;
            Description = description;
            SubDateTime = subDateTime;
            OralMark = oralMark;
            TotalMark = totalMark;
        }
    }
}
