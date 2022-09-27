using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSchool.Databases;
using PrivateSchool.Entities;



namespace PrivateSchool
{
    internal class ViewMenu
    {
        public static void PrintMenuOfSynthetics()
        {            
            Console.WriteLine("1 - Courses");
            Console.WriteLine("2 - Students");
            Console.WriteLine("3 - Trainers ");
            Console.WriteLine("4 - Assignments");
            Console.WriteLine("5 - Students per Course");
            Console.WriteLine("6 - Trainers per Course");
            Console.WriteLine("7 - Assignments per Course");
            Console.WriteLine("8 - Assignments per Student");
            Console.WriteLine("9 - Students that belong to more than one courses");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("10 - Press '10' to go Back");
            Console.WriteLine("11 - Press '11' to go to Main Menu");
            Console.WriteLine("E - Press 'E' to EXIT");
            Console.ResetColor();
        }
        public static void PrintMenuForCreate()
        {
            Console.WriteLine("1 - Create new Course");
            Console.WriteLine("2 - Create new Student");
            Console.WriteLine("3 - Create new Trainer");
            Console.WriteLine("4 - Create new Assignment");
            Console.WriteLine("5 - Match Trainers per Course");
            Console.WriteLine("6 - Match Students per Course");
            Console.WriteLine("7 - Match Assignments per Course");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("8 - Press '8' to go Back");
            Console.WriteLine("9 - Press '9' to go to Main Menu");
            Console.WriteLine("E - Press 'E' to EXIT");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Entites has to be created in order to be able to match them.");
        }
        public static void PrintCreatedData()
        {            
            Console.WriteLine("1 - Courses");
            Console.WriteLine("2 - Students");
            Console.WriteLine("3 - Trainers ");
            Console.WriteLine("4 - Assignments");
            Console.WriteLine("5 - Students per Course");
            Console.WriteLine("6 - Trainers per Course");
            Console.WriteLine("7 - Assignments per Course");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("8 - Press '8' to go Back");
            Console.WriteLine("9 - Press '9' to go to Main Menu");
            Console.WriteLine("E - Press 'E' to EXIT");
            Console.ResetColor();
        }
        public static void PrintMainMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("---- Wellcome  ----");
            Console.WriteLine("Would like to use synthetic data or create new?");
            Console.ResetColor();
            Console.WriteLine("Press 1 - View Synthetic Data");
            Console.WriteLine("Press 2 - Create New Data");
            Console.WriteLine("Press 3 - View Created Data");
            Console.WriteLine("Press E - EXIT");
        }
    }
}
