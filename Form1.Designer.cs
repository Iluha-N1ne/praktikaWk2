namespace praktikaWk2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Inf_Adm = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Verfy_Box = new System.Windows.Forms.TextBox();
            this.To_Reg = new System.Windows.Forms.Button();
            this.To_Log = new System.Windows.Forms.Button();
            this.Log_Btn = new System.Windows.Forms.Button();
            this.Reg_Btn = new System.Windows.Forms.Button();
            this.Pass_Box = new System.Windows.Forms.TextBox();
            this.Log_Box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Bck_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Inf_Adm
            // 
            this.Inf_Adm.AutoSize = true;
            this.Inf_Adm.Font = new System.Drawing.Font("Acherus Feral Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Inf_Adm.Location = new System.Drawing.Point(23, 299);
            this.Inf_Adm.Name = "Inf_Adm";
            this.Inf_Adm.Size = new System.Drawing.Size(121, 24);
            this.Inf_Adm.TabIndex = 21;
            this.Inf_Adm.Text = "Админ ключ:";
            this.Inf_Adm.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Acherus Feral Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Acherus Feral Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, -26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 24);
            this.label1.TabIndex = 19;
            this.label1.Text = "Логин:";
            // 
            // Verfy_Box
            // 
            this.Verfy_Box.Font = new System.Drawing.Font("Acherus Feral Bold", 19.8F, System.Drawing.FontStyle.Bold);
            this.Verfy_Box.Location = new System.Drawing.Point(26, 325);
            this.Verfy_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Verfy_Box.Multiline = true;
            this.Verfy_Box.Name = "Verfy_Box";
            this.Verfy_Box.Size = new System.Drawing.Size(205, 42);
            this.Verfy_Box.TabIndex = 18;
            this.Verfy_Box.Visible = false;
            // 
            // To_Reg
            // 
            this.To_Reg.Font = new System.Drawing.Font("Acherus Feral Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To_Reg.Location = new System.Drawing.Point(26, 179);
            this.To_Reg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.To_Reg.Name = "To_Reg";
            this.To_Reg.Size = new System.Drawing.Size(205, 44);
            this.To_Reg.TabIndex = 17;
            this.To_Reg.Text = "К регисстрации";
            this.To_Reg.UseVisualStyleBackColor = true;
            // 
            // To_Log
            // 
            this.To_Log.Font = new System.Drawing.Font("Acherus Feral Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.To_Log.Location = new System.Drawing.Point(27, 179);
            this.To_Log.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.To_Log.Name = "To_Log";
            this.To_Log.Size = new System.Drawing.Size(205, 44);
            this.To_Log.TabIndex = 16;
            this.To_Log.Text = "К авторизации";
            this.To_Log.UseVisualStyleBackColor = true;
            // 
            // Log_Btn
            // 
            this.Log_Btn.Font = new System.Drawing.Font("Acherus Feral Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Log_Btn.Location = new System.Drawing.Point(27, 243);
            this.Log_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Log_Btn.Name = "Log_Btn";
            this.Log_Btn.Size = new System.Drawing.Size(205, 43);
            this.Log_Btn.TabIndex = 15;
            this.Log_Btn.Text = "Подтвердить";
            this.Log_Btn.UseVisualStyleBackColor = true;
            // 
            // Reg_Btn
            // 
            this.Reg_Btn.Font = new System.Drawing.Font("Acherus Feral Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reg_Btn.Location = new System.Drawing.Point(27, 243);
            this.Reg_Btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Reg_Btn.Name = "Reg_Btn";
            this.Reg_Btn.Size = new System.Drawing.Size(205, 43);
            this.Reg_Btn.TabIndex = 14;
            this.Reg_Btn.Text = "Подтвердить";
            this.Reg_Btn.UseVisualStyleBackColor = true;
            // 
            // Pass_Box
            // 
            this.Pass_Box.Font = new System.Drawing.Font("Acherus Feral Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pass_Box.Location = new System.Drawing.Point(27, 115);
            this.Pass_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pass_Box.Multiline = true;
            this.Pass_Box.Name = "Pass_Box";
            this.Pass_Box.Size = new System.Drawing.Size(205, 42);
            this.Pass_Box.TabIndex = 13;
            // 
            // Log_Box
            // 
            this.Log_Box.Font = new System.Drawing.Font("Acherus Feral Bold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Log_Box.Location = new System.Drawing.Point(26, 45);
            this.Log_Box.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Log_Box.Multiline = true;
            this.Log_Box.Name = "Log_Box";
            this.Log_Box.Size = new System.Drawing.Size(205, 42);
            this.Log_Box.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Acherus Feral Bold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(23, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Логин:";
            // 
            // Bck_Btn
            // 
            this.Bck_Btn.Font = new System.Drawing.Font("Acherus Feral Bold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Bck_Btn.Location = new System.Drawing.Point(222, 4);
            this.Bck_Btn.Name = "Bck_Btn";
            this.Bck_Btn.Size = new System.Drawing.Size(37, 36);
            this.Bck_Btn.TabIndex = 23;
            this.Bck_Btn.Text = "*";
            this.Bck_Btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 393);
            this.Controls.Add(this.Bck_Btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Inf_Adm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Verfy_Box);
            this.Controls.Add(this.To_Reg);
            this.Controls.Add(this.To_Log);
            this.Controls.Add(this.Log_Btn);
            this.Controls.Add(this.Reg_Btn);
            this.Controls.Add(this.Pass_Box);
            this.Controls.Add(this.Log_Box);
            this.Name = "Form1";
            this.Text = "Вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Inf_Adm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Verfy_Box;
        private System.Windows.Forms.Button To_Reg;
        private System.Windows.Forms.Button To_Log;
        private System.Windows.Forms.Button Log_Btn;
        private System.Windows.Forms.Button Reg_Btn;
        private System.Windows.Forms.TextBox Pass_Box;
        private System.Windows.Forms.TextBox Log_Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Bck_Btn;
    }
}

