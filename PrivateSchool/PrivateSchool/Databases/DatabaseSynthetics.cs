using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSchool.Entities;
using PrivateSchool.Enums;


namespace PrivateSchool.Databases
{
    internal class DatabaseSynthetics
    {
        public List<Course> Courses { get; set; } = new List<Course>();
        public List<Trainer> Trainers { get; set; } = new List<Trainer>();
        public List<Student> Students { get; set; } = new List<Student>();
        public List<Assignment> Assignments { get; set; } = new List<Assignment>();

        public DatabaseSynthetics()
        {
            #region Seeding Courses
            Course c1 = new Course(1, "C#", "CB-8", CourseType.FullTime, new DateTime(2021, 10, 11), new DateTime(2022, 04, 11));
            Course c2 = new Course(2, "C#", "CB-8", CourseType.PartTime, new DateTime(2021, 10, 11), new DateTime(2022, 01, 11));
            Course c3 = new Course(3, "Java", "CB-8", CourseType.FullTime, new DateTime(2021, 11, 20), new DateTime(2022, 04, 11));
            Course c4 = new Course(4, "Java", "CB-8", CourseType.PartTime, new DateTime(2021, 11, 20), new DateTime(2022, 01, 11));
            #endregion
            
            #region Seeding Trainers
            Trainer t1 = new Trainer(1, "Panos", "Sakelarios", "C#, Java");
            t1.Courses.Add(c2);
            t1.Courses.Add(c4);
            c2.Trainers.Add(t1);
            c4.Trainers.Add(t1);
            

            Trainer t2 = new Trainer(2, "Stauros", "Gouleas", "C#");
            t2.Courses.Add(c1);
            c1.Trainers.Add(t2);

            Trainer t3 = new Trainer(3, "George", "Kessopoulos", "Java");
            t3.Courses.Add(c3);
            c3.Trainers.Add(t3);

            Trainer t4 = new Trainer(4, "Hlias", "Karagewrgos", "Java");
            t4.Courses.Add(c2);
            t4.Courses.Add(c4);
            c2.Trainers.Add(t4);
            c4.Trainers.Add(t4);

            Trainer t5 = new Trainer(5, "Xarhs", "Papamixahl", "C#, Java");
            t5.Courses.Add(c2);
            t5.Courses.Add(c4);
            c2.Trainers.Add(t5);
            c4.Trainers.Add(t5);
            #endregion

            #region Seeding Students

            Student s1 = new Student(1, "Labros", "Papadimitriou", new DateTime(1992, 07, 18), 2500);
            s1.Courses.Add(c1);
            c1.Students.Add(s1);

            Student s2 = new Student(2, "Giannis", "Mpatsinilas", new DateTime(1992, 10, 20), 4000);
            s2.Courses.Add(c1);
            c1.Students.Add(s2);

            Student s3 = new Student(3, "Michalhs", "Kiaoulias", new DateTime(1991, 05, 13), 3000);
            s3.Courses.Add(c1);
            c1.Students.Add(s3);

            Student s4 = new Student(4, "Viktoria", "Rontirh", new DateTime(1990, 12, 20), 3500);
            s4.Courses.Add(c1);
            c1.Students.Add(s4);

            Student s5 = new Student(5, "Vera", "Romanou", new DateTime(1992, 06, 17), 2500);
            s5.Courses.Add(c1);
            c1.Students.Add(s5);

            Student s6 = new Student(6, "Kostas", "Merzioths", new DateTime(1992, 07, 18), 2500);
            s6.Courses.Add(c1);
            c1.Students.Add(s6);

            Student s7 = new Student(7, "Eygenios", "Kastanou", new DateTime(1989, 02, 10), 2000);
            s7.Courses.Add(c3);
            c3.Students.Add(s7);

            Student s8 = new Student(8, "Apostolhs", "Galanhs", new DateTime(1993, 07, 28), 5500);
            s8.Courses.Add(c3);
            c3.Students.Add(s8);

            Student s9 = new Student(9, "Parhs", "Fountoulhs", new DateTime(1988, 05, 22), 3000);
            s9.Courses.Add(c3);
            c3.Students.Add(s9);

            Student s10 = new Student(10, "Thodwrhs", "Safos", new DateTime(1994, 01, 07), 2500);
            s10.Courses.Add(c2);
            c2.Students.Add(s10);
            s10.Courses.Add(c4);
            c4.Students.Add(s10);

            Student s11 = new Student(11, "Giwrgos", "Galazios", new DateTime(1994, 06, 18), 2000);
            s11.Courses.Add(c2);
            c2.Students.Add(s11);
            s11.Courses.Add(c4);
            c4.Students.Add(s11);

            Student s12 = new Student(12, "Manos", "Papoutsakhs", new DateTime(1993, 10, 16), 4000);
            s12.Courses.Add(c2);
            c2.Students.Add(s12);
            s12.Courses.Add(c4);
            c4.Students.Add(s12);

            Student s13 = new Student(13, "Evripidhs", "Papadakhs", new DateTime(1991, 05, 23), 3000);
            s13.Courses.Add(c2);
            c2.Students.Add(s13);
            s13.Courses.Add(c4);
            c4.Students.Add(s13);

            Student s14 = new Student(14, "Ismhnh", "Pardalakh", new DateTime(1990, 10, 19), 3500);
            s14.Courses.Add(c2);
            c2.Students.Add(s14);
            s14.Courses.Add(c4);
            c4.Students.Add(s14);

            Student s15 = new Student(15, "Rania", "Xatzinikolaou", new DateTime(1989, 07, 17), 2500);
            s15.Courses.Add(c2);
            c2.Students.Add(s15);
            s15.Courses.Add(c4);
            c4.Students.Add(s15);

            Student s16 = new Student(16, "Petros", "Tsalkas", new DateTime(1993, 02, 18), 5500);
            s16.Courses.Add(c2);
            c2.Students.Add(s16);
            s16.Courses.Add(c4);
            c4.Students.Add(s16);

            Student s17 = new Student(17, "Nikos", "Kalpakos", new DateTime(1990, 03, 08), 3000);
            s17.Courses.Add(c2);
            c2.Students.Add(s17);
            s17.Courses.Add(c4);
            c4.Students.Add(s17);

            Student s18 = new Student(18, "Alexhs", "Papastergiou", new DateTime(1985, 07, 25), 5000);
            s18.Courses.Add(c2);
            c2.Students.Add(s18);
            s18.Courses.Add(c4);
            c4.Students.Add(s18);

            Student s19 = new Student(19, "Nikos", "Ioannoglou", new DateTime(1987, 06, 23), 3500);
            s19.Courses.Add(c2);
            c2.Students.Add(s19);
            s19.Courses.Add(c4);
            c4.Students.Add(s19);

            Student s20 = new Student(20, "Vasiliki", "Flevarh", new DateTime(1991, 02, 17), 2000);
            s20.Courses.Add(c2);
            c2.Students.Add(s20);
            s20.Courses.Add(c4);
            c4.Students.Add(s20);
            #endregion

            #region Seeding Assignments
            Assignment a1 = new Assignment(1, "Addition_C#_Full", "Add 2 Numbers", new DateTime(2021, 10, 30), 40, 100);
            a1.Cource = c1;
            c1.Assignments.Add(a1);


            Assignment a2 = new Assignment(2, "Substract_C#_Full", "Substract 2 Numbers", new DateTime(2021, 11, 25), 40, 100);
            a2.Cource = c1;
            c1.Assignments.Add(a2);

            Assignment a3 = new Assignment(3, "Multiply_C#_Full", "Multiply 2 Numbers", new DateTime(2021, 12, 30), 40, 100);
            a3.Cource = c1;
            c1.Assignments.Add(a3);

            Assignment a4 = new Assignment(4, "Division_C#_Full", "Divide 2 Numbers", new DateTime(2022, 01, 27), 40, 100);
            a4.Cource = c1;
            c1.Assignments.Add(a4);

            Assignment a5 = new Assignment(5, "Power_C#_Full", "Find Power of 111", new DateTime(2022, 02, 28), 40, 100);
            a5.Cource = c1;
            c1.Assignments.Add(a5);

            Assignment a6 = new Assignment(6, "Square_C#_Full", "Find Square of 10", new DateTime(2022, 03, 18), 40, 100);
            a6.Cource = c1;
            c1.Assignments.Add(a6);

            Assignment a7 = new Assignment(7, "Complex_C#_Full", "Create a Complex Number", new DateTime(2022, 04, 05), 40, 100);
            a7.Cource = c1;
            c1.Assignments.Add(a7);

            Assignment a8 = new Assignment(8, "Addition_C#_Part", "Add 3 Numbers", new DateTime(2021, 10, 15), 60, 100);
            a8.Cource = c2;
            c2.Assignments.Add(a8);

            Assignment a9 = new Assignment(9, "Substract_C#_Part", "Substract 3 Numbers", new DateTime(2021, 10, 30), 60, 100);
            a9.Cource = c2;
            c2.Assignments.Add(a9);

            Assignment a10 = new Assignment(10, "Multiply_C#_Part", "Multiply 3 Numbers", new DateTime(2021, 11, 09), 60, 100);
            a10.Cource = c2;
            c2.Assignments.Add(a10);

            Assignment a11 = new Assignment(11, "Division_C#_Part", "Divide 3 Numbers", new DateTime(2021, 11, 22), 60, 100);
            a11.Cource = c2;
            c2.Assignments.Add(a11);

            Assignment a12 = new Assignment(12, "Power_C#_Part", "Find Power of 222", new DateTime(2021, 12, 10), 60, 100);
            a12.Cource = c2;
            c2.Assignments.Add(a12);

            Assignment a13 = new Assignment(13, "Square_C#_Part", "Find Square of 15", new DateTime(2021, 12, 22), 60, 100);
            a13.Cource = c2;
            c2.Assignments.Add(a13);

            Assignment a14 = new Assignment(14, "Complex_C#_Part", "Create two Complex Numbers", new DateTime(2022, 01, 08), 60, 100);
            a14.Cource = c2;
            c2.Assignments.Add(a14);

            Assignment a15 = new Assignment(15, "Addition_Java_Full", "Add 4 Numbers", new DateTime(2021, 10, 23), 40, 100);
            a15.Cource = c3;
            c3.Assignments.Add(a15);

            Assignment a16 = new Assignment(16, "Substract_Java_Full", "Substract 4 Numbers", new DateTime(2021, 11, 18), 40, 100);
            a16.Cource = c3;
            c3.Assignments.Add(a16);

            Assignment a17 = new Assignment(17, "Multiply_Java_Full", "Multiply 4 Numbers", new DateTime(2021, 12, 22), 40, 100);
            a17.Cource = c3;
            c3.Assignments.Add(a17);

            Assignment a18 = new Assignment(18, "Division_Java_Full", "Divide 4 Numbers", new DateTime(2022, 01, 21), 40, 100);
            a18.Cource = c3;
            c3.Assignments.Add(a18);

            Assignment a19 = new Assignment(19, "Power_Java_Full", "Find Power of 333", new DateTime(2022, 02, 21), 40, 100);
            a19.Cource = c3;
            c3.Assignments.Add(a19);

            Assignment a20 = new Assignment(20, "Square_Java_Full", "Find Square of 20", new DateTime(2022, 03, 14), 40, 100);
            a20.Cource = c3;
            c3.Assignments.Add(a20);

            Assignment a21 = new Assignment(21, "Complex_Java_Full", "Create three Complex Numbers", new DateTime(2022, 04, 01), 40, 100);
            a21.Cource = c3;
            c3.Assignments.Add(a21);

            Assignment a22 = new Assignment(22, "Addition_Java_Part", "Add 4 Numbers", new DateTime(2021, 10, 17), 60, 100);
            a22.Cource = c4;
            c4.Assignments.Add(a22);

            Assignment a23 = new Assignment(23, "Substract_Java_Part", "Substract 4 Numbers", new DateTime(2021, 10, 28), 60, 100);
            a23.Cource = c4;
            c4.Assignments.Add(a23);

            Assignment a24 = new Assignment(24, "Multiply_Java_Part", "Multiply 4 Numbers", new DateTime(2021, 11, 06), 60, 100);
            a24.Cource = c4;
            c4.Assignments.Add(a24);

            Assignment a25 = new Assignment(25, "Division_Java_Part", "Divide 4 Numbers", new DateTime(2021, 11, 19), 60, 100);
            a25.Cource = c4;
            c4.Assignments.Add(a25);

            Assignment a26 = new Assignment(26, "Power_Java_Part", "Find Power of 444", new DateTime(2021, 12, 08), 60, 100);
            a26.Cource = c4;
            c4.Assignments.Add(a26);

            Assignment a27 = new Assignment(27, "Square_Java_Part", "Find Square of 25", new DateTime(2021, 12, 20), 60, 100);
            a27.Cource = c4;
            c4.Assignments.Add(a27);

            Assignment a28 = new Assignment(28, "Complex_Java_Part", "Create four Complex Numbers", new DateTime(2022, 01, 06), 60, 100);
            a28.Cource = c4;
            c4.Assignments.Add(a28);
            #endregion

            #region Populate MyDatabase
            List<Course> courses = new List<Course>() { c1, c2, c3, c4 };
            Courses.AddRange(courses);

            List<Trainer> trainers = new List<Trainer>() { t1, t2, t3, t4, t5 };
            Trainers.AddRange(trainers);

            List<Student> students = new List<Student>() { s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16, s17, s18, s19, s20 };
            Students.AddRange(students);

            List<Assignment> assignments = new List<Assignment>() { a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25, a26, a27, a28 };
            Assignments.AddRange(assignments);
            #endregion
        }
    }
}
