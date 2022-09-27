using PrivateSchool.Controllers;
using PrivateSchool.Views;
using System;
using System.Collections.Generic;

namespace PrivateSchool
{
    class Application
    {
        ControllerSynthetic controllerSynthetic = new ControllerSynthetic();
        ControllerUser controllerUser = new ControllerUser();
        public void GetMainMenu()
        {
            string input;
            do
            {
                ViewMenu.PrintMainMenu();
                input = Console.ReadLine().ToUpper();
                Console.Clear();

                switch (input)
                {
                    case "1": GetSyntheticData(); break;
                    case "2": CreateData(); break;
                    case "3": GetCreatedData(); break;
                    case "E": Console.WriteLine("Thank you! Bye!"); break;
                    default:
                        break;
                }
            } while (input != "E");

        }
        public void GetSyntheticData()
        {
            string input;
            do
            {
                ViewMenu.PrintMenuOfSynthetics();
                input = Console.ReadLine().ToUpper();
                Console.Clear();
                switch (input)
                {
                    case "1": controllerSynthetic.GetCourses(); break;
                    case "2": controllerSynthetic.GetStudents(); break;
                    case "3": controllerSynthetic.GetTrainers(); break;
                    case "4": controllerSynthetic.GetAssignments(); break;
                    case "5": controllerSynthetic.GetStudentsPerCourse(); break;
                    case "6": controllerSynthetic.GetTrainersPerCourse(); break;
                    case "7": controllerSynthetic.GetAssignmentsPerCourse(); break;
                    case "8": controllerSynthetic.GetAssignmentsPerStudent(); break;
                    case "9": controllerSynthetic.GetStudentsWithMultiCourses(); break;
                    case "10": GetSyntheticData(); break;
                    case "11": GetMainMenu(); break;
                    case "E": Console.WriteLine("Thank you! Bye!"); break;
                    default:
                        break;
                }
            } while (input != "E");
        }
        public void CreateData()
        {
            string input;
            do
            {
                ViewMenu.PrintMenuForCreate();
                input = Console.ReadLine().ToUpper();
                Console.Clear();
                switch (input)
                {
                    case "1": controllerUser.CreateCourse(); break;
                    case "2": controllerUser.CreateStudent(); break;
                    case "3": controllerUser.CreateTrainer(); break;
                    case "4": controllerUser.CreateAssignment(); break;
                    case "5": controllerUser.MatchStudentsPerCourse(); break;
                    case "6": controllerUser.MatchTrainersPerCourse(); break;
                    case "7": controllerUser.MatchAssignmentsPerCourse(); break;
                    case "8": CreateData(); break;
                    case "9": GetMainMenu(); break;
                    case "E": Console.WriteLine("Thank you! Bye!"); break;
                    default: break;
                }
            } while (input != "E");

        }
        public void GetCreatedData()
        {
            string input;
            do
            {

                ViewMenu.PrintCreatedData();
                input = Console.ReadLine().ToUpper();
                Console.Clear();
                switch (input)
                {
                    case "1": controllerUser.GetCourses(); break;
                    case "2": controllerUser.GetStudents(); break;
                    case "3": controllerUser.GetTrainers(); break;
                    case "4": controllerUser.GetAssignments(); break;
                    case "5": controllerUser.GetStudentsPerCourse(); break;
                    case "6": controllerUser.GetTrainersPerCourse(); break;
                    case "7": controllerUser.GetAssignmentsPerCourse(); break;
                    case "8": GetCreatedData(); break;
                    case "9": GetMainMenu(); break;
                    case "E": Console.WriteLine("Thank you! Bye!"); break;
                    default:
                        break;
                }
            } while (input != "E");

        }

    }
}
