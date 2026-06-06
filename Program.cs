using System;
using System.Data.SqlClient;
using System.Configuration;

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
        }
    }
}
