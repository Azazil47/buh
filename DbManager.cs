using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget
{
    static class DbManager
    {
        static private string connectionString = "provider=Microsoft.Jet.OLEDB.4.0;Data Source=budget.mdb"; //Строка подключения
        static private OleDbConnection dbConnection;

        public static Boolean connectDb()
        {
            dbConnection = new OleDbConnection(connectionString);
            try
            {
                dbConnection.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static Boolean disconnectDb()
        {
            try
            {
                dbConnection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        
        public static List<String> selectCatIncome()//Получение списка категорий
        {
            List<String> list = new List<string>();
            string query = "SELECT * FROM category_incoming";
            OleDbCommand command = new OleDbCommand(query, dbConnection);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                list.Add((string) reader["name"]);
            }
            return list;
        }
    }
}
