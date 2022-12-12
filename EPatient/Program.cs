using System;
using System.Threading;
using System.Windows.Forms;
using EPatient.Models;
using EPatient.Views;

namespace EPatient
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

            //SplashScreen
            Thread t = new Thread(() =>
            {
                frmSplashScreen frm = new frmSplashScreen();
                Application.Run(frm);
            });
            t.Start();
            Thread.Sleep(3000);
            t.Abort();
            //End SplashScreen
            LoginFormSingleton loginFormSingleton = LoginFormSingleton.getInstance();
            Application.Run(loginFormSingleton.getLoginForm());
        }

    }
    
}
