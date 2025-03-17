using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using Org.BouncyCastle.Bcpg;
using SPO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace praktikaWk2.mainPage.orderPage
{
    public partial class orderPage : Form
    {
        public orderPage()
        {
            InitializeComponent();
        }

        #region ---Словари и ренейм---
        Dictionary<string, string> toRusName = new Dictionary<string, string>
        {
            { "id", "Номер" },
            { "Name", "Название" },
            { "Type", "Тип" },
            { "Cost", "Цена" },
            { "Description", "Комментрий" },

        };
        Dictionary<string, string> toEngName = new Dictionary<string, string>
        {
            { "Номер", "id" },
            { "Название", "Name" },
            { "Тип", "Type" },
            { "Цена", "Cost" },
            { "Комментрий", "Description" }
        };


        #endregion

        #region ---Переменные---
        DataTable dataTable = new DataTable();
        DataTable _dataTable = new DataTable();
        DataTable dataFromBD = new DataTable();

        string type = "";
        string purchase = "";
        int _id;
        int id;

        #endregion

        private void orderPage_Load(object sender, System.EventArgs e)
        {
            formLoad(Transfer.User.change);

            #region ---SQL---
            Transfer transfer = new Transfer();
            using (MySqlConnection conn = new MySqlConnection(transfer.getConnStr()))
            {
                try
                {
                    conn.Open();
                    string query = $@"SELECT * From Production;";
                    using (MySqlConnection connection = new MySqlConnection(transfer.getConnStr()))
                    {
                        MySqlCommand command = new MySqlCommand(query, connection);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        adapter.Fill(dataTable);
                        adapter.Fill(_dataTable);
                        dataGrid.DataSource = dataTable;
                        dataGrid.AutoGenerateColumns = true;
                        //MessageBox.Show($"Rows returned: {_dataTable.C}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.HResult.ToString());
                }
            }
            var dataSet = new DataSet();
            var table = (DataTable)dataGrid.DataSource;

            foreach (DataColumn column in table.Columns)
            {
                if (toRusName.TryGetValue(column.ColumnName, out string localizedName))
                {
                    column.ColumnName = localizedName;
                }
            }

            table.TableName = "Production";
            #endregion

            #region ---Заполнение sortCmBox---
            using (MySqlConnection conn = new MySqlConnection(transfer.getConnStr()))
            {
                try
                {
                    conn.Open();
                    string query = $@"SELECT typeName From typeProduction;";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            sortCmBox.Items.Add(reader["typeName"].ToString());
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
        public bool formLoad(bool change)
        {
            #region --- Вызов заполениения таблицы для проверки оформленных заказов ---
            bool prikol = (change) ? dataGrid1.Visible = true: dataGrid1.Visible = false;

            Transfer transfer = new Transfer();

            using (MySqlConnection conn = new MySqlConnection(transfer.getConnStr()))
            {
                try
                {
                    conn.Open();
                    string query1 = $@"SELECT Users.Login AS Логин, 
                                    Production.Name AS Товар, 
                                    typeProduction.typeName AS ТипПродукции, 
                                    Purchase.Cost AS Стоимость, 
                                    collectOrder AS Адрес
                           FROM Purchase 
                           LEFT JOIN Users ON User_id = Users.id
                           LEFT JOIN Production ON Production_id = Production.id
                           LEFT JOIN typeProduction ON prodType_id = typeProduction.id

                           WHERE Purchase.User_id = '{Transfer.id}';";
                    using (MySqlConnection connection = new MySqlConnection(transfer.getConnStr()))
                    {
                        MySqlCommand command = new MySqlCommand(query1, connection);
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        adapter.Fill(dataFromBD);
                        dataGrid1.DataSource = dataFromBD;
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.HResult.ToString());
                }
                return prikol;
            }
            #endregion
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            #region Отображение заказа в эдите
            Transfer transfer = new Transfer();

            string Purchase = dataGrid.Rows[dataGrid.CurrentRow.Index].Cells["Название"].Value.ToString();
            int Cost = int.Parse(dataGrid.Rows[dataGrid.CurrentRow.Index].Cells["Цена"].Value.ToString());

            purchaseBtn.Text = Purchase;
            costLbl.Text = Cost.ToString();
            #endregion
        }

        private void createOrderBtn_Click(object sender, EventArgs e)
        {
            purchase = purchaseBtn.Text;
            getFromProduction();
        }
        #region Получение всего нужного для заказа

        private void getFromProduction()
        {
            string query = $"SELECT id, type FROM Production WHERE Name = '{purchase}'";
            Transfer transfer = new Transfer();
            using (MySqlConnection conn = new MySqlConnection(transfer.getConnStr()))
            {
                try
                {
                    conn.Open();
                    
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        type = reader["type"] as string;
                        _id = (int)reader["id"];
                        reader.Close();
                        //MessageBox.Show(type);
                        getFromtypeProduction();
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, ex.HResult.ToString());
                }
            }
        }
        private void getFromtypeProduction()
        {
            string _query = $"SELECT id FROM typeProduction WHERE typeName = '{type}'";
            Transfer transfer = new Transfer();
            using (MySqlConnection conn = new MySqlConnection(transfer.getConnStr()))
            {
                conn.Open();
                using (MySqlCommand command = new MySqlCommand(_query, conn))
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    reader.Read();
                    id = (int)reader["id"];
                    reader.Close();
                    //MessageBox.Show(type);
                    insertIntoPurchase();
                }
                conn.Close();
            }
        }

        private void insertIntoPurchase()
        {
            string __query = $@"INSERT INTO Purchase (User_id, Production_id, prodType_id, Cost, collectOrder) VALUES(@User_id, @Production_id, @prodType_id, @Cost, @collectOrder)";
            Transfer transfer = new Transfer();
            using (MySqlConnection conn = new MySqlConnection(transfer.getConnStr()))
            {
                conn.Open();
                using (MySqlCommand cmd = new MySqlCommand(__query, conn))
                {
                    string str = costLbl.Text;
                    cmd.Parameters.AddWithValue("@User_id", Transfer.User._id);
                    cmd.Parameters.AddWithValue("@Production_id", _id);
                    cmd.Parameters.AddWithValue("@prodType_id", id);
                    cmd.Parameters.AddWithValue("@Cost", int.Parse(costLbl.Text));
                    cmd.Parameters.AddWithValue("@collectOrder", adressEdit.Text);
                    cmd.ExecuteNonQuery();
                    //MessageBox.Show($"{id}, {_id}");
                }
                
            }
        }

        #endregion
        #region Переключатели 
        private void collectOrderType_SelectedIndexChanged(object sender, EventArgs e)
        {
        
            bool visible = (collectOrderType.SelectedIndex == 1) ? adressEdit.ReadOnly = false : adressEdit.ReadOnly = true;
        
        }
        #endregion
        private void sortCmBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sortCmBox_TextUpdate(object sender, EventArgs e)
        {
            string query1 = $"SELECT * From Production Where Type = {sortCmBox.Text};";
        }
    }
}
