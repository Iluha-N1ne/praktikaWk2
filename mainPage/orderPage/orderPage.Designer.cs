namespace praktikaWk2.mainPage.orderPage
{
    partial class orderPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.createOrderBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.adressEdit = new System.Windows.Forms.TextBox();
            this.collectOrderType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.costLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.sortCmBox = new System.Windows.Forms.ComboBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.purchaseBtn = new System.Windows.Forms.TextBox();
            this.Bck_Btn = new System.Windows.Forms.Button();
            this.dataGrid1 = new System.Windows.Forms.DataGridView();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ваш заказ";
            // 
            // createOrderBtn
            // 
            this.createOrderBtn.Location = new System.Drawing.Point(18, 272);
            this.createOrderBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createOrderBtn.Name = "createOrderBtn";
            this.createOrderBtn.Size = new System.Drawing.Size(284, 69);
            this.createOrderBtn.TabIndex = 2;
            this.createOrderBtn.Text = "Сделать заказ";
            this.createOrderBtn.UseVisualStyleBackColor = true;
            this.createOrderBtn.Click += new System.EventHandler(this.createOrderBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "*Для выбора заказа нужно нажать на товар таблице";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(18, 88);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(284, 31);
            this.textBox2.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "ФИО получателя";
            // 
            // adressEdit
            // 
            this.adressEdit.Location = new System.Drawing.Point(18, 141);
            this.adressEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.adressEdit.Multiline = true;
            this.adressEdit.Name = "adressEdit";
            this.adressEdit.ReadOnly = true;
            this.adressEdit.Size = new System.Drawing.Size(284, 31);
            this.adressEdit.TabIndex = 26;
            // 
            // collectOrderType
            // 
            this.collectOrderType.FormattingEnabled = true;
            this.collectOrderType.Items.AddRange(new object[] {
            "Заберу сам",
            "Доставка"});
            this.collectOrderType.Location = new System.Drawing.Point(19, 248);
            this.collectOrderType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.collectOrderType.Name = "collectOrderType";
            this.collectOrderType.Size = new System.Drawing.Size(102, 21);
            this.collectOrderType.TabIndex = 27;
            this.collectOrderType.SelectedIndexChanged += new System.EventHandler(this.collectOrderType_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 233);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Тип получения заказа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 211);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Сумма к оплате";
            // 
            // costLbl
            // 
            this.costLbl.AutoSize = true;
            this.costLbl.Location = new System.Drawing.Point(182, 233);
            this.costLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.costLbl.Name = "costLbl";
            this.costLbl.Size = new System.Drawing.Size(152, 13);
            this.costLbl.TabIndex = 30;
            this.costLbl.Text = "*Тут будет циферка в рублях";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 125);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Адрес";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 184);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(382, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "*Станет активным если пользователь выберет тип получения \"доставка\"\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(313, 3);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Поиск конкретного товара";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(670, 12);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 35;
            this.label10.Text = "Сортировка";
            // 
            // sortCmBox
            // 
            this.sortCmBox.FormattingEnabled = true;
            this.sortCmBox.Location = new System.Drawing.Point(670, 30);
            this.sortCmBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sortCmBox.Name = "sortCmBox";
            this.sortCmBox.Size = new System.Drawing.Size(92, 21);
            this.sortCmBox.TabIndex = 34;
            this.sortCmBox.SelectedIndexChanged += new System.EventHandler(this.sortCmBox_SelectedIndexChanged);
            this.sortCmBox.TextUpdate += new System.EventHandler(this.sortCmBox_TextUpdate);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(315, 3);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(454, 388);
            this.dataGrid.TabIndex = 33;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
            // 
            // purchaseBtn
            // 
            this.purchaseBtn.Location = new System.Drawing.Point(18, 20);
            this.purchaseBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.purchaseBtn.Multiline = true;
            this.purchaseBtn.Name = "purchaseBtn";
            this.purchaseBtn.ReadOnly = true;
            this.purchaseBtn.Size = new System.Drawing.Size(284, 31);
            this.purchaseBtn.TabIndex = 22;
            // 
            // Bck_Btn
            // 
            this.Bck_Btn.Font = new System.Drawing.Font("Acherus Feral Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bck_Btn.Location = new System.Drawing.Point(19, 358);
            this.Bck_Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Bck_Btn.Name = "Bck_Btn";
            this.Bck_Btn.Size = new System.Drawing.Size(40, 40);
            this.Bck_Btn.TabIndex = 38;
            this.Bck_Btn.Text = "↩";
            this.Bck_Btn.UseVisualStyleBackColor = true;
            // 
            // dataGrid1
            // 
            this.dataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid1.Location = new System.Drawing.Point(9, 3);
            this.dataGrid1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.RowHeadersWidth = 51;
            this.dataGrid1.RowTemplate.Height = 24;
            this.dataGrid1.Size = new System.Drawing.Size(765, 582);
            this.dataGrid1.TabIndex = 39;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(315, 20);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(351, 31);
            this.textBox4.TabIndex = 36;
            // 
            // orderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 408);
            this.Controls.Add(this.dataGrid1);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.Bck_Btn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.sortCmBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.costLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.collectOrderType);
            this.Controls.Add(this.adressEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.purchaseBtn);
            this.Controls.Add(this.createOrderBtn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "orderPage";
            this.Text = "orderPage >>> Форма оформления заказа";
            this.Load += new System.EventHandler(this.orderPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createOrderBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adressEdit;
        private System.Windows.Forms.ComboBox collectOrderType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label costLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox sortCmBox;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TextBox purchaseBtn;
        private System.Windows.Forms.Button Bck_Btn;
        private System.Windows.Forms.DataGridView dataGrid1;
        private System.Windows.Forms.TextBox textBox4;
    }
}