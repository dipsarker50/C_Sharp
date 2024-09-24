using Database;
using System;
using WinFormsApp1.Adminpanel;
using WinFormsApp1.Patients;

namespace WinFormsApp1;

internal static class Program
{

    [STAThread]
    static void Main()
    {


       

        ApplicationConfiguration.Initialize();
        Application.Run(new SignIn());
    }     

}