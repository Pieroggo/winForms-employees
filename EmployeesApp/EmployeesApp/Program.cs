using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace EmployeesApp
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var view = new View.Form1();
            var model = new Model.Model();
            var presenter = new Presenter.Presenter(model,view);
            Application.Run(view);
        }
    }
}
