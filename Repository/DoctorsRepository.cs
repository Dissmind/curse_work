using curse_work.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace curse_work.Repository
{
    class DoctorsRepository
    {
        public static ICollection GetAll()
        {
            return new List<int>();
        }

        public static void Add(DoctorModel data)
        {
            var db = new DB();

            string query = $"INSERT doctors VALUES (null, '{data.Name}', '{data.Type}')";

            db.OpenConnection();

            MySqlCommand command = new MySqlCommand(query, db.GetConnection());

            MySqlDataReader reader = command.ExecuteReader();

            db.CloseConnection();

        }


        public static void Delete(int id)
        {
            var db = new DB();

            string query = $"DELETE FROM doctors WHERE id = {id}";

            db.OpenConnection();

            MySqlCommand command = new MySqlCommand(query, db.GetConnection());

            db.CloseConnection();
        }
    }
}
