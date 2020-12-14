using curse_work.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace curse_work.Repository
{
    class DoctorsRepository
    {

        public static void Add(DoctorModel data)
        {
            var db = new DB();

            string query = $"INSERT doctors VALUES (null, '{data.Name}', '{data.Type}')";

            db.OpenConnection();

            MySqlCommand command = new MySqlCommand(query, db.GetConnection());

            MySqlDataReader reader = command.ExecuteReader();

            db.CloseConnection();

        }
    }
}
