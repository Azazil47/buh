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
        } // подключение к БД

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
        }//Отключение от БД

        public static List<String> selectAllfromTable(string table, string collum)//Получение поле name из таблицы (Имя таблицы, имя столбца)
        {
            List<String> list = new List<string>();
            string query = $"SELECT * FROM {table}";
            OleDbCommand command = new OleDbCommand(query, dbConnection);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                list.Add((string)reader[collum]);
            }
            reader.Close();
            return list;
        }

        public static int getId (string table, string value) //получение id из любой таблицы передается (таблица, значение поля) 
        {
            string query = $"SELECT id FROM {table} WHERE name IN('{value}')";
            OleDbCommand command = new OleDbCommand(query, dbConnection);
            object id = -1;
            id = command.ExecuteScalar();
            if (id != null) //Получение id имеющейся записи
            {
                return (int) id;
            }
            else //Добавление новой записи если такой нет и получение ее id
            {
                string queryadd = $"INSERT INTO {table} (name) VALUES(\"{value}\")";
                OleDbCommand commandadd = new OleDbCommand(queryadd, dbConnection);
                commandadd.ExecuteNonQuery();
                return (int)command.ExecuteScalar();
            }
        }

        //public static Boolean CheckForMatches(string table, string collum, string matches)
        //{
        //    Boolean flag = false;
        //    foreach (var item in selectAllfromTable(table, collum))
        //    {
        //        if (matches == item)
        //        {
        //            flag = true;
        //        }
        //    }
        //    return flag;
        //}

        //public static void addIncomeCategory(string table, string category)
        //{
        //    if (!CheckForMatches(category, "category_incoming", "name"))
        //    {
        //        string query = $"INSERT INTO {table} (name) VALUES(\"{category}\")";
        //        OleDbCommand command = new OleDbCommand(query, dbConnection);
        //        command.ExecuteNonQuery();
        //    }
        //}

        public static void addIncome(string table, string category, int sum/*, double sum, DateTime date*/) //доветси до ума
        {
            int id = getId("category_incoming", category);
            string queryadd = "INSERT INTO incoming (id_category, sum) VALUES (2, 500)";
            
            OleDbCommand commandadd = new OleDbCommand(queryadd, dbConnection);
            commandadd.ExecuteNonQuery();
        }
    }
}

