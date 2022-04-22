using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUDWinFormsMVP.Models;
using CRUDWinFormsMVP.Presenters;
using CRUDWinFormsMVP._Repositories;
using CRUDWinFormsMVP.Views;
using System.Configuration;

namespace CRUDWinFormsMVP
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
            string sqlConnectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
            IMainView view = new MainView();           
            new MainPresenter(view,sqlConnectionString);
            Application.Run((Form)view);
        }
    }
}
