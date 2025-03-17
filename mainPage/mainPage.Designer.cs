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
            this.Bck_Btn = new System.Windows.Forms.Button();
            this.makePurchaseBtn = new System.Windows.Forms.Button();
            this.commitPurchaseBtn = new System.Windows.Forms.Button();
            this.hiLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Bck_Btn
            // 
            this.Bck_Btn.Font = new System.Drawing.Font("Acherus Feral Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bck_Btn.Location = new System.Drawing.Point(12, 449);
            this.Bck_Btn.Name = "Bck_Btn";
            this.Bck_Btn.Size = new System.Drawing.Size(50, 49);
            this.Bck_Btn.TabIndex = 15;
            this.Bck_Btn.Text = "↩";
            this.Bck_Btn.UseVisualStyleBackColor = true;
            // 
            // makePurchaseBtn
            // 
            this.makePurchaseBtn.Location = new System.Drawing.Point(25, 169);
            this.makePurchaseBtn.Name = "makePurchaseBtn";
            this.makePurchaseBtn.Size = new System.Drawing.Size(445, 75);
            this.makePurchaseBtn.TabIndex = 16;
            this.makePurchaseBtn.Text = "Сделать заказ...";
            this.makePurchaseBtn.UseVisualStyleBackColor = true;
            this.makePurchaseBtn.Click += new System.EventHandler(this.makePurchaseBtn_Click);
            // 
            // commitPurchaseBtn
            // 
            this.commitPurchaseBtn.Location = new System.Drawing.Point(25, 264);
            this.commitPurchaseBtn.Name = "commitPurchaseBtn";
            this.commitPurchaseBtn.Size = new System.Drawing.Size(445, 75);
            this.commitPurchaseBtn.TabIndex = 23;
            this.commitPurchaseBtn.Text = "Ваши заказы";
            this.commitPurchaseBtn.UseVisualStyleBackColor = true;
            this.commitPurchaseBtn.Click += new System.EventHandler(this.commitPurchaseBtn_Click);
            // 
            // hiLbl
            // 
            this.hiLbl.AutoSize = true;
            this.hiLbl.Location = new System.Drawing.Point(173, 54);
            this.hiLbl.Name = "hiLbl";
            this.hiLbl.Size = new System.Drawing.Size(140, 16);
            this.hiLbl.TabIndex = 24;
            this.hiLbl.Text = "Здравствуйте, NNN!";
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 510);
            this.Controls.Add(this.hiLbl);
            this.Controls.Add(this.commitPurchaseBtn);
            this.Controls.Add(this.makePurchaseBtn);
            this.Controls.Add(this.Bck_Btn);
            this.Name = "mainPage";
            this.Text = "mainPage >>> Главная форма пользователя";
            this.Load += new System.EventHandler(this.mainPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Bck_Btn;
        private System.Windows.Forms.Button makePurchaseBtn;
        private System.Windows.Forms.Button commitPurchaseBtn;
        private System.Windows.Forms.Label hiLbl;
    }
}