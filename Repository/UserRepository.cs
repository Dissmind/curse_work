using curse_work.Models;
using MySql.Data.MySqlClient;
using System.Windows;

namespace curse_work.Repository
{
    class UserRepository
    {
        public static int Login(User user)
        {
            DB db = new DB();

            const string TABLE = "user";

            string query = $"SELECT COUNT(id) FROM {TABLE} WHERE login = '{user.Login}' AND password = '{user.Password}'";

            db.OpenConnection();

            MySqlCommand command = new MySqlCommand(query, db.GetConnection());

            MySqlDataReader reader = command.ExecuteReader();

            reader.Read();

            //int id = cmd.ExecuteScalar();

            MessageBox.Show(reader.GetInt32("id").ToString());

            db.CloseConnection();

            //return id;
            return 1;
        }
    }
}
