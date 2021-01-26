using System;
using System.Data;
using System.Data.SqlClient;

namespace FinalProject
{
    class DataBase
    {

        private static string _connectionString = "Data Source=.\\SQLExpress;Database = FinalProject;Integrated Security=true;";

        public static SqlConnection Connection = new SqlConnection(_connectionString);
        public static string Except { get; private set; }

        public static void SetConnection()
        {
            try
            {
                Connection.Open();
            }
            catch (Exception ex)
            {
                Except = ex.Message;
            }
        }
    }
}
