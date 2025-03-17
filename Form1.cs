using System;
using System.Windows.Forms;
using SPO;

namespace praktikaWk2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region -- Переключатели--

        string role = "user";

        private void To_Log_Click(object sender, EventArgs e)
        {
            if (Adm_Lb.Visible == true)
            {
                Login_Pnl.Visible = true;
            }
            else
            {
                Verfy_Box.Visible = false;
                Inf_Adm.Visible = false;
                Adm_Lb.Visible = true;

                role = "user";
            }
        }
        #endregion

        private void Log_Btn_Click(object sender, EventArgs e)
        {
            string Login = Log_Box.Text; Login = Login.Replace(" ", "");
            string Password = Pass_Box.Text; Password = Password.Replace(" ", "");

            Transfer transfer = new Transfer();
            transfer.Inspect(Login, Password, role);

        }
        private void label6_Click(object sender, EventArgs e)
        {
            Login_Pnl.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Code = Verfy_Box.Text; Code = Code.Replace(" ", "");
            string Login = Log_Box.Text; Login = Login.Replace(" ", "");
            string Password = Pass_Box.Text; Password = Password.Replace(" ", "");
            if (Code == "admin")
            {
                if (Login != "" || Password != "")
                {
                    CodePass.CreateHash(Login, Password, role);
                }
                else
                {
                    MessageBox.Show("Введите что либо в поля для ввода");
                }
            }
            else
            {
                MessageBox.Show("Используйте ключ администратора для регистрации");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Adm_Lb.Visible = false;
            Verfy_Box.Visible = true;
            Inf_Adm.Visible = true;

            role = "admin";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Pass_Box.PasswordChar == '*')
            {
                Pass_Box.PasswordChar = '\0';
                Pass_Btn.Text = "👁️";
            }
            else
            {
                Pass_Box.PasswordChar = '*';
                Pass_Btn.Text = "👁️‍🗨️";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
