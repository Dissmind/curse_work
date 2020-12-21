using curse_work.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace curse_work.Repository
{
    public class MedWatchRepository
    {
        public static ICollection GetAll()
        {
            var result = new List<MedWatchModel>();

            var db = new DB();

            string table = "med_watch";
            string query = $"SELECT * FROM {table}";

            db.OpenConnection();

            MySqlCommand command = new MySqlCommand(query, db.GetConnection());

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                var data = new MedWatchModel
                    (
                        Int32.Parse(reader.GetValue(0).ToString()),
                        reader.GetValue(1).ToString(),
                        Int32.Parse(reader.GetValue(2).ToString()),
                        reader.GetValue(3).ToString(),
                        reader.GetValue(4).ToString()
                    );

                result.Add(data);
            }

            db.CloseConnection();

            return result;
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
