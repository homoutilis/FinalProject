using System;
using System.Data;
using System.Data.SqlClient;

namespace FinalProject
{
    class DataBase
    {
        public static string Except { get; private set; }

        public static string kLine { get; set; }
        public static void SetConnection()
        {
            string connectionString = "Data Source=.\\SQLExpress;Database = FinalProject;Integrated Security=true;";

            // Provide the query string with a parameter placeholder.
            string queryString = $"INSERT INTO dbo.OUTAGES (kLine, dtOff, kReason) VALUES({kLine}, '25.01.2021', 1)";

            // Specify the parameter value.
            //int paramValue = 5;

            // Create and open the connection in a using block. This
            // ensures that all resources will be closed and disposed
            // when the code exits.
            using (SqlConnection connection =
                new SqlConnection(connectionString))
            {
                // Create the Command and Parameter objects.
                SqlCommand command = new SqlCommand(queryString, connection);

                // Open the connection in a try/catch block.
                // Create and execute the DataReader, writing the result
                // set to the console window.
                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                    }
                    reader.Close();

                    Except = "Все ОК!";
                }
                catch (Exception ex)
                {
                    Except = ex.Message;
                }
            }
        }
    }
}
