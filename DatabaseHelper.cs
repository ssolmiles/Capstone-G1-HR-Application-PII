using MySql.Data.MySqlClient;

namespace HRApplicantSystem
{
    public static class DatabaseHelper
    {
        private static string connectionString =
            "Server=localhost;Database=HRApplicantDB;Uid=root;Pwd=YOUR_PASSWORD;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}