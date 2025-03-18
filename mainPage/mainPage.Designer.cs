namespace praktikaWk2.mainPage
{
    partial class mainPage
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
            this.hiLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.PictureBox();
            this.commitPurchaseBtn = new System.Windows.Forms.PictureBox();
            this.makePurchaseBtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commitPurchaseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makePurchaseBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // hiLbl
            // 
            this.hiLbl.Font = new System.Drawing.Font("Acherus Feral Bold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hiLbl.Location = new System.Drawing.Point(28, 9);
            this.hiLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hiLbl.Name = "hiLbl";
            this.hiLbl.Size = new System.Drawing.Size(379, 175);
            this.hiLbl.TabIndex = 24;
            this.hiLbl.Text = "Здравствуйте, NNN!";
            this.hiLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Transparent;
            this.exitBtn.Image = global::praktikaWk2.Properties.Resources.Button3;
            this.exitBtn.Location = new System.Drawing.Point(139, 449);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(157, 73);
            this.exitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.exitBtn.TabIndex = 27;
            this.exitBtn.TabStop = false;
            // 
            // commitPurchaseBtn
            // 
            this.commitPurchaseBtn.BackColor = System.Drawing.Color.Transparent;
            this.commitPurchaseBtn.Image = global::praktikaWk2.Properties.Resources.Button1;
            this.commitPurchaseBtn.Location = new System.Drawing.Point(82, 296);
            this.commitPurchaseBtn.Name = "commitPurchaseBtn";
            this.commitPurchaseBtn.Size = new System.Drawing.Size(264, 73);
            this.commitPurchaseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.commitPurchaseBtn.TabIndex = 26;
            this.commitPurchaseBtn.TabStop = false;
            this.commitPurchaseBtn.Click += new System.EventHandler(this.commitPurchaseBtn_Click);
            // 
            // makePurchaseBtn
            // 
            this.makePurchaseBtn.BackColor = System.Drawing.Color.Transparent;
            this.makePurchaseBtn.Image = global::praktikaWk2.Properties.Resources.Button1;
            this.makePurchaseBtn.Location = new System.Drawing.Point(82, 187);
            this.makePurchaseBtn.Name = "makePurchaseBtn";
            this.makePurchaseBtn.Size = new System.Drawing.Size(264, 73);
            this.makePurchaseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.makePurchaseBtn.TabIndex = 25;
            this.makePurchaseBtn.TabStop = false;
            this.makePurchaseBtn.Click += new System.EventHandler(this.makePurchaseBtn_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.label1.Font = new System.Drawing.Font("Acherus Feral Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(87, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 41);
            this.label1.TabIndex = 28;
            this.label1.Text = "Сделать заказ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.makePurchaseBtn_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.label2.Font = new System.Drawing.Font("Acherus Feral Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(87, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 41);
            this.label2.TabIndex = 29;
            this.label2.Text = "Ваши заказы";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.commitPurchaseBtn_Click);
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(431, 577);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.commitPurchaseBtn);
            this.Controls.Add(this.makePurchaseBtn);
            this.Controls.Add(this.hiLbl);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(447, 616);
            this.MinimumSize = new System.Drawing.Size(447, 616);
            this.Name = "mainPage";
            this.Text = "mainPage >>> Главная форма пользователя";
            this.Load += new System.EventHandler(this.mainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commitPurchaseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makePurchaseBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label hiLbl;
        private System.Windows.Forms.PictureBox makePurchaseBtn;
        private System.Windows.Forms.PictureBox commitPurchaseBtn;
        private System.Windows.Forms.PictureBox exitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}