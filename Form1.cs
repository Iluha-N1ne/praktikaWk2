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
            Reg_Pnl.Visible = false;
            Login_Pnl.Visible = true;
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
            Reg_Pnl.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Login = Log_Box.Text; Login = Login.Replace(" ", "");
            string Password = Pass_Box.Text; Password = Password.Replace(" ", "");
            if (Login != "" || Password != "")
            {
                   CodePass.CreateHash(Login, Password, role);
            }
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

        private void chngAuto_Click(object sender, EventArgs e)
        {
            Reg_Lb.Show();
            chngAuto.Show();

            Log_Box.Text = "";
            Pass_Box.Text = "";

            Log_Box.Undo();
            Pass_Box.Undo();
        }

        private void chngAuto_Click_1(object sender, EventArgs e)
        {
            chngAuto.Hide();
            Reg_Lb.Hide();
            toSotrid.Show();

            Login_Pnl.Show();
            Reg_Pnl.Hide();

            Log_Box.Undo();
            Pass_Box.Undo();
        }
    }
}
