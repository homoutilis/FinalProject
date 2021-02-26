using System;
using System.Data.SqlClient;
using System.IO;

namespace FinalProject
{
    static class VarBinary
    {
        static public string Except { get; private set; }
        
        static public void AddAppToDB()
        {
            string fileName = "image.jpg";
            byte[] fileByteArray = File.ReadAllBytes(fileName);

            string queryString = $"INSERT INTO D_SETTINGS (kSet, nSet, binData) VALUES ((SELECT MAX(kSet)+1 FROM D_SETTINGS), @fn, @bd)";

            SqlCommand command = new SqlCommand(queryString, DataBase.Connection);

            try
            {
                command.Parameters.Add("fn", System.Data.SqlDbType.NVarChar, 255).Value = Path.GetFileName(fileName);
                command.Parameters.Add("bd", System.Data.SqlDbType.VarBinary).Value = fileByteArray;
                command.ExecuteNonQuery();
                //command.Close();

                Except = "Файл успешно записан в базу данных!";
            }
            catch (Exception ex)
            {
                Except = ex.Message;
            }
        }
    }
}
