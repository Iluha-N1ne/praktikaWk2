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
            this.Bck_Btn = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.slctTableCmBox = new System.Windows.Forms.ComboBox();
            this.ToDB_Btn = new System.Windows.Forms.Button();
            this.Dlt_Btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Bck_Btn
            // 
            this.Bck_Btn.Font = new System.Drawing.Font("Acherus Feral Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bck_Btn.Location = new System.Drawing.Point(12, 12);
            this.Bck_Btn.Name = "Bck_Btn";
            this.Bck_Btn.Size = new System.Drawing.Size(54, 49);
            this.Bck_Btn.TabIndex = 39;
            this.Bck_Btn.Text = "↩";
            this.Bck_Btn.UseVisualStyleBackColor = true;
            this.Bck_Btn.Click += new System.EventHandler(this.Bck_Btn_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 68);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(776, 410);
            this.dataGrid.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(667, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 16);
            this.label10.TabIndex = 42;
            this.label10.Text = "Выбрать таблицу";
            // 
            // slctTableCmBox
            // 
            this.slctTableCmBox.FormattingEnabled = true;
            this.slctTableCmBox.Location = new System.Drawing.Point(667, 38);
            this.slctTableCmBox.Name = "slctTableCmBox";
            this.slctTableCmBox.Size = new System.Drawing.Size(121, 24);
            this.slctTableCmBox.TabIndex = 41;
            this.slctTableCmBox.SelectedIndexChanged += new System.EventHandler(this.slctTableCmBox_SelectedIndexChanged);
            // 
            // ToDB_Btn
            // 
            this.ToDB_Btn.Font = new System.Drawing.Font("Acherus Feral Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToDB_Btn.Location = new System.Drawing.Point(607, 12);
            this.ToDB_Btn.Name = "ToDB_Btn";
            this.ToDB_Btn.Size = new System.Drawing.Size(54, 49);
            this.ToDB_Btn.TabIndex = 43;
            this.ToDB_Btn.Text = "↩";
            this.ToDB_Btn.UseVisualStyleBackColor = true;
            this.ToDB_Btn.Click += new System.EventHandler(this.ToDB_Btn_Click);
            // 
            // Dlt_Btn
            // 
            this.Dlt_Btn.Font = new System.Drawing.Font("Acherus Feral Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dlt_Btn.Location = new System.Drawing.Point(547, 12);
            this.Dlt_Btn.Name = "Dlt_Btn";
            this.Dlt_Btn.Size = new System.Drawing.Size(54, 49);
            this.Dlt_Btn.TabIndex = 44;
            this.Dlt_Btn.Text = "↩";
            this.Dlt_Btn.UseVisualStyleBackColor = true;
            this.Dlt_Btn.Click += new System.EventHandler(this.Dlt_Btn_Click);
            // 
            // adminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.Dlt_Btn);
            this.Controls.Add(this.ToDB_Btn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.slctTableCmBox);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.Bck_Btn);
            this.Name = "adminPage";
            this.Text = "adminPage >>> Страница администратора";
            this.Load += new System.EventHandler(this.adminPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bck_Btn;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox slctTableCmBox;
        private System.Windows.Forms.Button ToDB_Btn;
        private System.Windows.Forms.Button Dlt_Btn;
    }
}