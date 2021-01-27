using System;
using System.Data.SqlClient;

namespace FinalProject
{
    class Outage
    {
        public string kLine { get; set; }

        public string nReason { get; set; }

        public string dtOutage { get; set; }

        public string Query { get; set; }

        public string Except { get; private set; }

        public void InsertOutage()
        {
            string queryString = $"INSERT INTO OUTAGES (kLine, dtOff, nReason) VALUES({kLine}, '{dtOutage}', '{nReason}')";

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
