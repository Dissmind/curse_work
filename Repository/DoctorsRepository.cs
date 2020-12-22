using curse_work.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace curse_work.Repository
{
    public class DoctorsRepository
    {
        public static List<DoctorModel> GetAll()
        {
            var result = new List<DoctorModel>();

            var db = new DB();

            string table = "doctors";
            string query = $"SELECT * FROM {table}";

            db.OpenConnection();

            MySqlCommand command = new MySqlCommand(query, db.GetConnection());

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                var data = new DoctorModel
                    (
                        Int32.Parse(reader.GetValue(0).ToString()),
                        reader.GetValue(1).ToString(),
                        reader.GetValue(2).ToString()
                    );

                result.Add(data);
            }

            db.CloseConnection();

            return result;
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
            command.ExecuteNonQuery();

            db.CloseConnection();
        }
    }
}
