using curse_work.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace curse_work.Repository
{
    public class TestRepository
    {
        public static Title GetById(int id) 
        {
            Title data = new Title();
            DB db = new DB();

            const string TABLE = "title";

            string query = $"SELECT * FROM {TABLE} WHERE (id = {id})";

            db.OpenConnection();

            MySqlCommand command = new MySqlCommand(query, db.GetConnection());

            MySqlDataReader reader = command.ExecuteReader();

            reader.Read();

            data.Id = reader.GetInt32("id");
            data.Value = reader.GetString("title");

            db.CloseConnection();

            return data;
        }


        public static void Add(Title data)
        {
            DB db = new DB();

            const string TABLE = "title";

            string query = $"INSERT INTO {TABLE} (id, title) VALUE (null, '{data.Value}')";

            db.OpenConnection();

            MySqlCommand command = new MySqlCommand(query, db.GetConnection());

            MySqlDataReader reader = command.ExecuteReader();

            db.CloseConnection();
        }
    }
}
