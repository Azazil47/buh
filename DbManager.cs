﻿using System;
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
        
        public static List<String> selectAllfromTable(string table)//Получение поле name из таблицы
        {
            List<String> list = new List<string>();
            string query = $"SELECT * FROM {table}";
            OleDbCommand command = new OleDbCommand(query, dbConnection);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                list.Add((string) reader["name"]);
            }
            return list;
        }

        public static Boolean CheckForMatches(string matches, string table)
        {
            Boolean flag = false;
            foreach (var item in selectAllfromTable(table))
            {
                if (matches == item)
                {
                    //string query = $"INSERT INTO {table} VALUES(\"{matches}\")";
                    flag = true;
                }
            }
            return flag;
        }

        public static void addIncome(string category, string name, double sum, DateTime date)
        {
            
        }
    }
}
