using System;
using System.Windows.Forms;
using HRApplicantSystem.Forms.Applicant;

namespace HRApplicantSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmApplicantLogin());
        }
    }
}