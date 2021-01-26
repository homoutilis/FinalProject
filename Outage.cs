using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FinalProject
{
    public class Outage
    {
        public static string kLine { get; set; }

        public static string kReason { get; set; }

        public static string dtOutage { get; set; }

        public string Query { get; set; }

        public static string Except { get; private set; }

        public static void InsertOutage()
        {
            string queryString = $"INSERT INTO dbo.OUTAGES (kLine, dtOff, kReason) VALUES({kLine}, '{dtOutage}', 1)";

            SqlCommand command = new SqlCommand(queryString, DataBase.Connection);
            
            try
            {
                SqlDataReader reader = command.ExecuteReader();
                reader.Close();

                Except = "Данные по отключению успешно сохранены!";
            }
            catch (Exception ex)
            {
                Except = ex.Message;
            }
        }

        public override string ToString()
        {
            return $"Добавление отключения линии 10кВ";
        }
                
    }
}
