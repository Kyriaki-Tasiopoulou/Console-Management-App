using PrivateSchool.Entities;
using PrivateSchool.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PrivateSchool.Views
{
    internal class ViewForCreate
    {
        public static Course CreateCourse()
        {
            string title;
            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Enter the title of Course");
                Console.ResetColor();
                title = Console.ReadLine();
            } while (string.IsNullOrEmpty(title) || string.IsNullOrWhiteSpace(title));

            string stream;
            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Enter the stream of Course");
                Console.WriteLine("Stream must be from CB-8 to CB-15, at this format.");
                Console.ResetColor();
                stream = Console.ReadLine();
            } while (!Validation.IsValidCourseStream(stream));


            string typeInput;
            CourseType type;
            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Choose 1 or 2 for the type of Course");
                Console.WriteLine("1 - Full Time");
                Console.WriteLine("2 - Part Time");
                Console.ResetColor();
                typeInput = Console.ReadLine();
            } while (typeInput != "1" && typeInput != "2");
            type = (CourseType)Convert.ToInt32(typeInput);

            string startDateInput;
            DateTime startDate;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Enter the Start Date");
            Console.ResetColor();
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Start Date can NOT be in the past! Format: 20-12-2022");
                Console.ResetColor();
                startDateInput = Console.ReadLine();
            } while (!Validation.IsValidDate(startDateInput, out startDate));

            string endDateInput;
            DateTime endDate;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Enter the End Date");
            Console.ResetColor();
            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("End Date can NOT be in the past! Format: 20-12-2022");
                Console.ResetColor();
                endDateInput = Console.ReadLine();
            } while (!Validation.IsValidDate(endDateInput, out endDate));

            Course course = new Course()
            {
                Title = title,
                Stream = stream,
                Type = type,
                StartDate = startDate,
                EndDate = endDate
            };
            return course;
        }
        public static Student CreateStudent()
        {
            string firstName;
            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Enter the First Name of the Student");
                Console.ResetColor();
                firstName = Console.ReadLine();
            } while (Validation.IsValidName(firstName));

            string lastName;
            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Enter the Last Name of the Student");
                Console.ResetColor();
                lastName = Console.ReadLine();
            } while (Validation.IsValidName(lastName));

            string dateOfBirthInput;
            DateTime dateOfBirth;
            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Enter Date Of Birth - Format: 12-12-2022");
                Console.ResetColor();
                dateOfBirthInput = Console.ReadLine();
            } while (!Validation.IsValidDateOfBirth(dateOfBirthInput, out dateOfBirth));

            string feesInput;
            int fees;
            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Enter the Student's Fees");
                Console.ResetColor();
                feesInput = Console.ReadLine();
            } while (!Validation.IsValidFees(feesInput));
            fees = Convert.ToInt32(feesInput);

            Student student = new Student()
            {
                FirstName = firstName,
                LastName = lastName,
                DateOfBirth = dateOfBirth,
                Fees = fees
            };
            return student;
        }
        public static Trainer CreateTrainer()
        {
            string firstName;
            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Enter the First Name of the Trainer");
                Console.ResetColor();
                firstName = Console.ReadLine();
            } while (Validation.IsValidName(firstName));

            string lastName;
            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Enter the Last Name of the Trainer");
                Console.ResetColor();
                lastName = Console.ReadLine();
            } while (Validation.IsValidName(lastName));

            string subject;
            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Enter the Subject of the Trainer");
                Console.ResetColor();
                subject = Console.ReadLine();
            } while (string.IsNullOrEmpty(subject));


            Trainer trainer = new Trainer()
            {
                FirstName = firstName,
                LastName = lastName,
                Subject = subject
            };
            return trainer;
        }
        public static Assignment CreateAssignment()
        {
            string title;
            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Enter the Title of the Assignment");
                Console.ResetColor();
                title = Console.ReadLine();
            } while (string.IsNullOrEmpty(title));

            string description;
            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Enter a short description of the Assignment");
                Console.ResetColor();
                description = Console.ReadLine();
            } while (string.IsNullOrEmpty(description));



            string subDateTimeInput;
            DateTime subDateTime;
            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Enter the submission Date Time");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Submission Date can NOT be in the past! Format:12-11-2022");
                Console.ResetColor();
                subDateTimeInput = Console.ReadLine();
            } while (!Validation.IsValidDate(subDateTimeInput, out subDateTime));


            string oralMarkInput;
            int oralMark;
            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Enter the Oral Mark");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Oral Mark can NOT be over 100! and must have only numbers");
                Console.ResetColor();
                oralMarkInput = Console.ReadLine();
            } while (!Validation.IsValidMark(oralMarkInput, out oralMark));

            string totalMarkInput;
            int totalMark;
            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Enter the Oral Mark");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Oral Mark can NOT be over 100! and must have only numbers");
                Console.ResetColor();
                totalMarkInput = Console.ReadLine();
            } while (!Validation.IsValidMark(totalMarkInput, out totalMark));

            Assignment assignment = new Assignment()
            {
                Title = title,
                Description = description,
                SubDateTime = subDateTime,
                OralMark = oralMark,
                TotalMark = totalMark
            };
            return assignment;
        }

    }
}
