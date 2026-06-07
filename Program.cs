using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRApplicantSystem.Forms.Applicant;
b25e3ecda80535cca6999a1fd548b62551a4c251

namespace HRApplicantSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection conn = new SqlConnection(connString))

            {
                try
                {
                    conn.Open();
                    Console.WriteLine("✅ Connection successful!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Connection failed: " + ex.Message);
                }
            }

            Console.ReadLine(); // Keeps the console open
        /// <summary>
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmApplicantLogin());
b25e3ecda80535cca6999a1fd548b62551a4c251
        }
    }
}
