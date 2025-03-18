using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SPO;

namespace praktikaWk2.adminPage
{
    public partial class adminPage : Form
    {
        public adminPage()
        {
            InitializeComponent();
        }
        Dictionary<string, string> columnNames = new Dictionary<string, string>
        {
            { "Номер", "id" },
            { "Логин", "Login" },
            { "Хеш", "Hash" },
            { "Соль", "Salt" },
            { "Роль", "Role" },
            { "Название", "Name" },
            { "Тип", "Type" },
            { "Описание", "Description" },
            { "ТипПродукта", "typeName" },
            { "Стоимость", "Cost"},
            { "Адрес","collectOrder" },
            { "Цена","Cost" }
        };

        private void changeDB()
        {
            #region ---SQL---
            string query;
            if (table == "Users")
            {
                query = $@"SELECT id AS Номер,
                        Login AS Логин, 
                        HEX(Hash) AS Хеш, 
                        HEX(Salt) AS Соль, 
                        Role AS Роль FROM Users;";
                fillDataGrid(query);
            }
            if (table == "Production")
            {
                query = $@"SELECT id AS Номер,
                        Name AS Название, 
                        Type AS Тип, 
                        Description As Описание, 
                        Cost AS Цена FROM Production;";
                fillDataGrid(query);
            }
            if (table == "typeProduction")
            {
                query = $@"SELECT id AS Номер,
                        typeName As ТипПродукта FROM typeProduction;";
                fillDataGrid(query);
            }
            if (table == "Purchase")
            {
                query = $@"SELECT Purchase.id AS Номер,
                        User_id AS Пользователь, 
                        Production_id AS Товар, 
                        prodType_id AS ТипТовара,
                        Purchase.Cost AS Стоимость,
                        collectOrder AS Адрес
                           FROM Purchase 
                        LEFT JOIN Users ON Purchase.User_id = Users.id
                        LEFT JOIN Production ON Production_id = Production.id
                        LEFT JOIN typeProduction ON prodType_id = typeProduction.id;";
                fillDataGrid(query);
            }
            #endregion
        }

        private void fillDataGrid(string query)
        {
            Transfer transfer = new Transfer();
            using (MySqlConnection connection = new MySqlConnection(transfer.getConnStr()))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGrid.DataSource = dataTable;
                dataGrid.AutoGenerateColumns = true;
            }
        }

        private void ToDB(string tableName)
        {
            #region ---Region---
            var dataSet = new DataSet();
            var table = (DataTable)dataGrid.DataSource;

            foreach (DataColumn column in table.Columns)
            {
                if (columnNames.TryGetValue(column.ColumnName, out string localizedName))
                {
                    column.ColumnName = localizedName;
                }
            }

            table.TableName = tableName;
            dataSet.Tables.Add(table);

            Transfer transfer = new Transfer();
            try
            {
                using (var conn = new MySqlConnection(transfer.getConnStr()))
                {

                    var adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = new MySqlCommand($"SELECT * FROM {tableName}", conn);
                    var builder = new MySqlCommandBuilder(adapter);

                    adapter.InsertCommand = builder.GetInsertCommand();
                    adapter.Update(dataSet, tableName);
                }
                dataSet.Reset();
                changeDB();
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.ToString());
            }
            #endregion
        }

        private void Dlt_Btn_Click(object sender, EventArgs e)
        {
            #region ---Удлаение---
            Transfer transfer = new Transfer();
            try
            {
                int ID = int.Parse(dataGrid.Rows[dataGrid.CurrentRow.Index].Cells["Номер"].Value.ToString());
                using (MySqlConnection connection = new MySqlConnection(transfer.getConnStr()))
                {
                    string query = $"DELETE FROM {table} WHERE id = {ID}";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        changeDB();
                    }
                    catch (Exception ex)
                    {
                        changeDB();
                        MessageBox.Show($"Ошибка: {ex.Message}");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
            #endregion
        }

        string table;

        private void ToDB_Btn_Click(object sender, EventArgs e)
        {
            ToDB(table);
        }

        private void Users_Btn_Click(object sender, EventArgs e)
        {
            Users_Btn.BackColor = Color.FromArgb(134, 22, 26);
            Purchase_Btn.BackColor = Color.FromArgb(217, 31, 37);
            Production_Btn.BackColor = Color.FromArgb(217, 31, 37);
            typeProduction_Btn.BackColor = Color.FromArgb(217, 31, 37);

            table = "Users";
            changeDB();
        }

        private void Purchase_Btn_Click(object sender, EventArgs e)
        {
            Users_Btn.BackColor = Color.FromArgb(217, 31, 37);
            Purchase_Btn.BackColor = Color.FromArgb(134, 22, 26);
            Production_Btn.BackColor = Color.FromArgb(217, 31, 37);
            typeProduction_Btn.BackColor = Color.FromArgb(217, 31, 37);

            table = "Purchase";
            changeDB();
        }

        private void Production_Btn_Click(object sender, EventArgs e)
        {
            Users_Btn.BackColor = Color.FromArgb(217, 31, 37);
            Purchase_Btn.BackColor = Color.FromArgb(217, 31, 37);
            Production_Btn.BackColor = Color.FromArgb(134, 22, 26);
            typeProduction_Btn.BackColor = Color.FromArgb(217, 31, 37);

            table = "Production";
            changeDB();
        }

        private void typeProduction_Btn_Click(object sender, EventArgs e)
        {
            Users_Btn.BackColor = Color.FromArgb(217, 31, 37);
            Purchase_Btn.BackColor = Color.FromArgb(217, 31, 37);
            Production_Btn.BackColor = Color.FromArgb(217, 31, 37);
            typeProduction_Btn.BackColor = Color.FromArgb(134, 22, 26);

            table = "typeProduction";
            changeDB();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
