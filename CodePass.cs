using praktikaWk2;
using praktikaWk2.adminPage;
using praktikaWk2.mainPage;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace SPO
{
    internal class CodePass
    {
        #region -- Константы --
        public const int saltSize = 24; // размер соли
        public const int hashSize = 24; // размер хеша
        public const int itr = 100000; // число иттераций
        #endregion

        public static string CreateHash(string Login, string Password, string role)
        {
            // Генерируем соль
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            byte[] salt = new byte[saltSize];
            provider.GetBytes(salt);
            //string readableSalt = BitConverter.ToString(salt).Replace("-", "").ToLower();

            // Генерируем хеш-пароль
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(Password, salt, itr);
            byte[] hash = pbkdf2.GetBytes(hashSize);
            string readableHash = BitConverter.ToString(hash).Replace("-", "").ToLower();

            //MessageBox.Show($"{Login},  {readableHash}");
            //Передаём логин, хеш, соль в метод Add в классе ToDatabase

            //ToDatabase transfer = new ToDatabase(Connection.ConnStr);
            Transfer ToDataBase = new Transfer();
            ToDataBase.Add(Login, hash, salt, role);

            return Login;
        }
        //Проверка хеша из БД и введённого пользователем хеша
        public static bool VerifyHash(string Password, byte[] hash, byte[] salt, string role)
        {
            var pbkdf2 = new Rfc2898DeriveBytes(Password, salt, itr);
            byte[] temphash = pbkdf2.GetBytes(hashSize);
            //string hasher = BitConverter.ToString(temphash).Replace("-", "").ToLower();
            //MessageBox.Show($"{hasher},{hash}");
            if (hash.SequenceEqual(temphash))
            {
                string entryUser = string.Empty;
                MessageBox.Show($"true user login, ${role}");

                Form1 _transfer = new Form1();
                if(role == "admin")
                {
                    adminPage __trasfer = new adminPage();
                    __trasfer.Show();
                    _transfer.Close();
                }
                else
                {
                mainPage trasfer = new mainPage();

                trasfer.Show();
                _transfer.Hide();
                }

            }
            else
            {
                MessageBox.Show("Попробуйдте другой логин / пароль");
            }
            return hash.SequenceEqual(temphash);
        }
    }
}
