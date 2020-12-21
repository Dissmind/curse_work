using curse_work.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace curse_work.Repository
{
    class MedWatchRepository
    {
        public static ICollection GetAll()
        {
            return new List<int>();
        }


        public static void Add(MedWatchModel data)
        {
            var db = new DB();

            string query = $"INSERT doctors VALUES (null, '{data.Name}', {data.DoctorId}, '{data.Time}', '{data.Description}')";

            db.OpenConnection();

            MySqlCommand command = new MySqlCommand(query, db.GetConnection());

            db.CloseConnection();
        }


        public static void Delete(int id)
        {

        }
    }
}
