namespace praktikaWk2.adminPage
{
    partial class adminPage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Dlt_Btn = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Users_Btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Purchase_Btn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Production_Btn = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.typeProduction_Btn = new System.Windows.Forms.Button();
            this.ToDB_Btn = new System.Windows.Forms.PictureBox();
            this.Dlt_Lb = new System.Windows.Forms.Label();
            this.ToDB_Lb = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dlt_Btn)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToDB_Btn)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Acherus Feral Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGrid.Location = new System.Drawing.Point(260, 11);
            this.dataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(725, 440);
            this.dataGrid.TabIndex = 40;
            // 
            // Dlt_Btn
            // 
            this.Dlt_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Dlt_Btn.BackColor = System.Drawing.Color.Transparent;
            this.Dlt_Btn.Image = global::praktikaWk2.Properties.Resources.Button1;
            this.Dlt_Btn.Location = new System.Drawing.Point(260, 468);
            this.Dlt_Btn.Name = "Dlt_Btn";
            this.Dlt_Btn.Size = new System.Drawing.Size(264, 73);
            this.Dlt_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Dlt_Btn.TabIndex = 45;
            this.Dlt_Btn.TabStop = false;
            this.Dlt_Btn.Click += new System.EventHandler(this.Dlt_Btn_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-3, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(235, 554);
            this.flowLayoutPanel1.TabIndex = 46;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 88);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Acherus Feral Bold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 52);
            this.label2.TabIndex = 1;
            this.label2.Text = "Таблицы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Acherus Feral Bold", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "                           ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Users_Btn);
            this.panel2.Location = new System.Drawing.Point(3, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 67);
            this.panel2.TabIndex = 1;
            // 
            // Users_Btn
            // 
            this.Users_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Users_Btn.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Users_Btn.ForeColor = System.Drawing.Color.White;
            this.Users_Btn.Location = new System.Drawing.Point(-2, -9);
            this.Users_Btn.Name = "Users_Btn";
            this.Users_Btn.Size = new System.Drawing.Size(242, 82);
            this.Users_Btn.TabIndex = 0;
            this.Users_Btn.Text = "Аккаунты";
            this.Users_Btn.UseVisualStyleBackColor = true;
            this.Users_Btn.Click += new System.EventHandler(this.Users_Btn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Purchase_Btn);
            this.panel3.Location = new System.Drawing.Point(3, 170);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(232, 67);
            this.panel3.TabIndex = 2;
            // 
            // Purchase_Btn
            // 
            this.Purchase_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Purchase_Btn.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Purchase_Btn.ForeColor = System.Drawing.Color.White;
            this.Purchase_Btn.Location = new System.Drawing.Point(-2, -9);
            this.Purchase_Btn.Name = "Purchase_Btn";
            this.Purchase_Btn.Size = new System.Drawing.Size(242, 82);
            this.Purchase_Btn.TabIndex = 0;
            this.Purchase_Btn.Text = "Заказы";
            this.Purchase_Btn.UseVisualStyleBackColor = true;
            this.Purchase_Btn.Click += new System.EventHandler(this.Purchase_Btn_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Production_Btn);
            this.panel4.Location = new System.Drawing.Point(3, 243);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(232, 67);
            this.panel4.TabIndex = 3;
            // 
            // Production_Btn
            // 
            this.Production_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Production_Btn.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Production_Btn.ForeColor = System.Drawing.Color.White;
            this.Production_Btn.Location = new System.Drawing.Point(-2, -9);
            this.Production_Btn.Name = "Production_Btn";
            this.Production_Btn.Size = new System.Drawing.Size(242, 82);
            this.Production_Btn.TabIndex = 0;
            this.Production_Btn.Text = "Меню";
            this.Production_Btn.UseVisualStyleBackColor = true;
            this.Production_Btn.Click += new System.EventHandler(this.Production_Btn_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.typeProduction_Btn);
            this.panel5.Location = new System.Drawing.Point(3, 316);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(232, 67);
            this.panel5.TabIndex = 4;
            // 
            // typeProduction_Btn
            // 
            this.typeProduction_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.typeProduction_Btn.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeProduction_Btn.ForeColor = System.Drawing.Color.White;
            this.typeProduction_Btn.Location = new System.Drawing.Point(-2, -9);
            this.typeProduction_Btn.Name = "typeProduction_Btn";
            this.typeProduction_Btn.Size = new System.Drawing.Size(242, 82);
            this.typeProduction_Btn.TabIndex = 0;
            this.typeProduction_Btn.Text = "Продукция";
            this.typeProduction_Btn.UseVisualStyleBackColor = true;
            this.typeProduction_Btn.Click += new System.EventHandler(this.typeProduction_Btn_Click);
            // 
            // ToDB_Btn
            // 
            this.ToDB_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ToDB_Btn.BackColor = System.Drawing.Color.Transparent;
            this.ToDB_Btn.Image = global::praktikaWk2.Properties.Resources.Button1;
            this.ToDB_Btn.Location = new System.Drawing.Point(553, 468);
            this.ToDB_Btn.Name = "ToDB_Btn";
            this.ToDB_Btn.Size = new System.Drawing.Size(264, 73);
            this.ToDB_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ToDB_Btn.TabIndex = 47;
            this.ToDB_Btn.TabStop = false;
            this.ToDB_Btn.Click += new System.EventHandler(this.ToDB_Btn_Click);
            // 
            // Dlt_Lb
            // 
            this.Dlt_Lb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Dlt_Lb.AutoSize = true;
            this.Dlt_Lb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.Dlt_Lb.Font = new System.Drawing.Font("Acherus Feral Bold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dlt_Lb.ForeColor = System.Drawing.Color.White;
            this.Dlt_Lb.Location = new System.Drawing.Point(309, 482);
            this.Dlt_Lb.Name = "Dlt_Lb";
            this.Dlt_Lb.Size = new System.Drawing.Size(163, 49);
            this.Dlt_Lb.TabIndex = 48;
            this.Dlt_Lb.Text = "Удалить";
            this.Dlt_Lb.Click += new System.EventHandler(this.Dlt_Btn_Click);
            // 
            // ToDB_Lb
            // 
            this.ToDB_Lb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ToDB_Lb.AutoSize = true;
            this.ToDB_Lb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.ToDB_Lb.Font = new System.Drawing.Font("Acherus Feral Bold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToDB_Lb.ForeColor = System.Drawing.Color.White;
            this.ToDB_Lb.Location = new System.Drawing.Point(583, 482);
            this.ToDB_Lb.Name = "ToDB_Lb";
            this.ToDB_Lb.Size = new System.Drawing.Size(211, 49);
            this.ToDB_Lb.TabIndex = 49;
            this.ToDB_Lb.Text = "Сохранить";
            this.ToDB_Lb.Click += new System.EventHandler(this.ToDB_Btn_Click);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.panel7.Controls.Add(this.button1);
            this.panel7.Location = new System.Drawing.Point(-3, 487);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(232, 67);
            this.panel7.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(-2, -9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(242, 82);
            this.button1.TabIndex = 0;
            this.button1.Text = "Выход";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(996, 553);
            this.Controls.Add(this.ToDB_Lb);
            this.Controls.Add(this.Dlt_Lb);
            this.Controls.Add(this.ToDB_Btn);
            this.Controls.Add(this.Dlt_Btn);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "adminPage";
            this.Text = "adminPage >>> Страница администратора";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dlt_Btn)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ToDB_Btn)).EndInit();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.PictureBox Dlt_Btn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Users_Btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Purchase_Btn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button Production_Btn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button typeProduction_Btn;
        private System.Windows.Forms.PictureBox ToDB_Btn;
        private System.Windows.Forms.Label Dlt_Lb;
        private System.Windows.Forms.Label ToDB_Lb;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button1;
    }
}