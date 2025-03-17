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
            this.label1.Location = new System.Drawing.Point(32, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ваш заказ";
            // 
            // createOrderBtn
            // 
            this.createOrderBtn.Location = new System.Drawing.Point(24, 335);
            this.createOrderBtn.Name = "createOrderBtn";
            this.createOrderBtn.Size = new System.Drawing.Size(379, 85);
            this.createOrderBtn.TabIndex = 2;
            this.createOrderBtn.Text = "Сделать заказ";
            this.createOrderBtn.UseVisualStyleBackColor = true;
            this.createOrderBtn.Click += new System.EventHandler(this.createOrderBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "*Для выбора заказа нужно нажать на товар таблице";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(24, 108);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(377, 37);
            this.textBox2.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "ФИО получателя";
            // 
            // adressEdit
            // 
            this.adressEdit.Location = new System.Drawing.Point(24, 173);
            this.adressEdit.Multiline = true;
            this.adressEdit.Name = "adressEdit";
            this.adressEdit.ReadOnly = true;
            this.adressEdit.Size = new System.Drawing.Size(377, 37);
            this.adressEdit.TabIndex = 26;
            // 
            // collectOrderType
            // 
            this.collectOrderType.FormattingEnabled = true;
            this.collectOrderType.Items.AddRange(new object[] {
            "Заберу сам",
            "Доставка"});
            this.collectOrderType.Location = new System.Drawing.Point(25, 305);
            this.collectOrderType.Name = "collectOrderType";
            this.collectOrderType.Size = new System.Drawing.Size(134, 24);
            this.collectOrderType.TabIndex = 27;
            this.collectOrderType.SelectedIndexChanged += new System.EventHandler(this.collectOrderType_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Тип получения заказа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Сумма к оплате";
            // 
            // costLbl
            // 
            this.costLbl.AutoSize = true;
            this.costLbl.Location = new System.Drawing.Point(243, 287);
            this.costLbl.Name = "costLbl";
            this.costLbl.Size = new System.Drawing.Size(198, 16);
            this.costLbl.TabIndex = 30;
            this.costLbl.Text = "*Тут будет циферка в рублях";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "Адрес";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(489, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "*Станет активным если пользователь выберет тип получения \"доставка\"\r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(417, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 16);
            this.label9.TabIndex = 37;
            this.label9.Text = "Поиск конкретного товара";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(893, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 16);
            this.label10.TabIndex = 35;
            this.label10.Text = "Сортировка";
            // 
            // sortCmBox
            // 
            this.sortCmBox.FormattingEnabled = true;
            this.sortCmBox.Location = new System.Drawing.Point(893, 37);
            this.sortCmBox.Name = "sortCmBox";
            this.sortCmBox.Size = new System.Drawing.Size(121, 24);
            this.sortCmBox.TabIndex = 34;
            this.sortCmBox.SelectedIndexChanged += new System.EventHandler(this.sortCmBox_SelectedIndexChanged);
            this.sortCmBox.TextUpdate += new System.EventHandler(this.sortCmBox_TextUpdate);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(420, 4);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(605, 477);
            this.dataGrid.TabIndex = 33;
            this.dataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_CellClick);
            // 
            // purchaseBtn
            // 
            this.purchaseBtn.Location = new System.Drawing.Point(24, 24);
            this.purchaseBtn.Multiline = true;
            this.purchaseBtn.Name = "purchaseBtn";
            this.purchaseBtn.ReadOnly = true;
            this.purchaseBtn.Size = new System.Drawing.Size(377, 37);
            this.purchaseBtn.TabIndex = 22;
            // 
            // Bck_Btn
            // 
            this.Bck_Btn.Font = new System.Drawing.Font("Acherus Feral Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bck_Btn.Location = new System.Drawing.Point(25, 441);
            this.Bck_Btn.Name = "Bck_Btn";
            this.Bck_Btn.Size = new System.Drawing.Size(54, 49);
            this.Bck_Btn.TabIndex = 38;
            this.Bck_Btn.Text = "↩";
            this.Bck_Btn.UseVisualStyleBackColor = true;
            // 
            // dataGrid1
            // 
            this.dataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid1.Location = new System.Drawing.Point(12, 4);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.RowHeadersWidth = 51;
            this.dataGrid1.RowTemplate.Height = 24;
            this.dataGrid1.Size = new System.Drawing.Size(1020, 716);
            this.dataGrid1.TabIndex = 39;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(420, 24);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(467, 37);
            this.textBox4.TabIndex = 36;
            // 
            // orderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 502);
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