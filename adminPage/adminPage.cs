using System;
using System.Collections.Generic;
using System.Data;
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

        private void Bck_Btn_Click(object sender, EventArgs e)
        {

        }

        private void adminPage_Load(object sender, EventArgs e)
        {
            #region ---SQL---
            Transfer transfer = new Transfer();
            using (MySqlConnection conn = new MySqlConnection(transfer.getConnStr()))
            {
                try
                {
                    conn.Open();
                    string query = $@"SELECT table_name FROM information_schema.tables WHERE table_schema = 'Market';";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            slctTableCmBox.Items.Add(reader["table_name"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.HResult.ToString());
                }
            }
            #endregion
        }

        private void slctTableCmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeDB();
        }
        private void changeDB()
        {
            #region ---SQL---
            string query;
            if (slctTableCmBox.Text == "Users")
            {
                query = $@"SELECT id AS Номер,
                        Login AS Логин, 
                        HEX(Hash) AS Хеш, 
                        HEX(Salt) AS Соль, 
                        Role AS Роль FROM Users;";
                fillDataGrid(query);
            }
            if (slctTableCmBox.Text == "Production")
            {
                query = $@"SELECT id AS Номер,
                        Name AS Название, 
                        Type AS Тип, 
                        Description As Описание, 
                        Cost AS Цена FROM Production;";
                fillDataGrid(query);
            }
            if (slctTableCmBox.Text == "typeProduction")
            {
                query = $@"SELECT id AS Номер,
                        typeName As ТипПродукта FROM typeProduction;";
                fillDataGrid(query);
            }
            if (slctTableCmBox.Text == "Purchase")
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
                //MessageBox.Show($"Rows returned: {dataTable.Rows.Count}");

                foreach (DataColumn column in dataTable.Columns) { MessageBox.Show(column.ColumnName); }

            }
        }
        //
        private void ToDB_Btn_Click(object sender, EventArgs e)
        {
            ToDB();
        }
        private void ToDB()
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

            table.TableName = slctTableCmBox.Text;
            dataSet.Tables.Add(table);

            foreach (DataColumn column in table.Columns) { MessageBox.Show(column.ColumnName); }

            Transfer transfer = new Transfer();
            try
            {
                using (var conn = new MySqlConnection(transfer.getConnStr()))
                {

                    var adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = new MySqlCommand($"SELECT * FROM {slctTableCmBox.Text}", conn);
                    var builder = new MySqlCommandBuilder(adapter);

                    adapter.InsertCommand = builder.GetInsertCommand();
                    adapter.Update(dataSet, slctTableCmBox.Text);
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
                    string query = $"DELETE FROM {slctTableCmBox.Text} WHERE id = {ID}";
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
    }
}
