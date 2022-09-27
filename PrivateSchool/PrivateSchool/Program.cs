using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateSchool.Controllers;
using PrivateSchool.Databases;
using PrivateSchool.Entities;
using PrivateSchool.Enums;
using PrivateSchool.Repos;

namespace PrivateSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Run program = new Run();
            program.GetStarted();
        }      

        class Run
        {
            Application application = new Application();

            public void GetStarted()
            {
                application.GetMainMenu();
            }
        }
    }
}
