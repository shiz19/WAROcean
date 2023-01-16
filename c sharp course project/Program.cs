using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using c_sharp_course_project.resources;

namespace c_sharp_course_project
{
    static class Program
    {
       
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
           // Application.Run(new Records());
            //Application.Run(new Game());//тестирование самого игрового процесса, минуя вход и меню
        }
    }
}