using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace SPO
{
    internal class Transfer
    {
        public string getConnStr()
        {
            string connectionString = "Server=95.183.12.18;" +
                "Port=3306;" +
                "Database=Market;" +
                "User=Basement;";
            return connectionString;
        }
        public class User
        {
            public static int _id = id;
            public static bool change;
            public static string Name = _Name;
        }
        public static int id;
        public static string _Name;
        public bool Unique(string Login, MySqlConnection conn)
        {
            using (MySqlCommand cmd = new MySqlCommand("SELECT COUNT(*) FROM Users WHERE Login = @Login", conn))
            {
                cmd.Parameters.AddWithValue("@Login", Login);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count == 0;
            }
        }
        public void Add(string Login, byte[] hash, byte[] salt, string Role)
        {
            using (MySqlConnection conn = new MySqlConnection(getConnStr()))
            {
                conn.Open();
                if (Unique(Login, conn))
                {
                    using (MySqlCommand cmd = new MySqlCommand("AddUser", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@Login", Login);
                        cmd.Parameters.AddWithValue("@Hash", hash);
                        cmd.Parameters.AddWithValue("@Salt", salt);
                        cmd.Parameters.AddWithValue("@Role", Role);

                        MessageBox.Show($"Пользователь {Login} был успешно добавлен");

                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    MessageBox.Show($"Пользователь {Login} найден в базе, используйте другой");
                }
            }
        }
        public void Inspect(string Login, string Pass, string role)
        {
            using (MySqlConnection conn = new MySqlConnection(getConnStr()))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, Hash, Salt, Role FROM Users WHERE Login = @login";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@login", Login);
                        if (Unique(Login, conn) == false)
                        {
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                reader.Read();
                                byte[] hash = reader["Hash"] as byte[];
                                byte[] salt = reader["Salt"] as byte[];
                                role = reader["Role"] as string;
                                id = (int)reader["id"];

                                _Name = Login;

                                //MessageBox.Show($"Hash: {hash}, Salt: {salt}");

                                CodePass.VerifyHash(Pass, hash, salt, role);
                            }
                        }
                        else
                        {
                            MessageBox.Show($"Пользователь с логином '{Login}' не найден");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.HelpLink);
                }
            }
        }
    }
}


