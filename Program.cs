using System;
using System.IO;
using System.Windows.Forms;
using HRApplicantSystem.Forms;
using HRApplicantSystem.Helpers;

namespace HRApplicantSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string iniPath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Database",
                "db_config.ini");

            try
            {
                DatabaseHelper.LoadConfig(iniPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Failed to load database config:\n{ex.Message}\n\nMake sure Database\\db_config.ini exists.",
                    "Startup Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            Application.Run(new frmRoleSelection());
        }
    }
}