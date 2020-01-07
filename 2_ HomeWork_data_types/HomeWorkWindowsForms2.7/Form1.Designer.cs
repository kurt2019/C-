namespace HomeWorkWindowsForms2._7
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
            this.button1 = new System.Windows.Forms.Button();
            this.year_for_user = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button1.FlatAppearance.BorderSize = 10;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Gigi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(275, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 94);
            this.button1.TabIndex = 2;
            this.button1.Text = "Розрахувати";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // year_for_user
            // 
            this.year_for_user.BackColor = System.Drawing.Color.Yellow;
            this.year_for_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.year_for_user.ForeColor = System.Drawing.Color.Blue;
            this.year_for_user.Location = new System.Drawing.Point(275, 178);
            this.year_for_user.MaxLength = 8;
            this.year_for_user.Name = "year_for_user";
            this.year_for_user.Size = new System.Drawing.Size(217, 38);
            this.year_for_user.TabIndex = 1;
            this.year_for_user.TextChanged += new System.EventHandler(this.year_for_user_TextChanged);
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.Color.Gray;
            this.result.Font = new System.Drawing.Font("Kunstler Script", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result.ForeColor = System.Drawing.Color.Yellow;
            this.result.Location = new System.Drawing.Point(275, 359);
            this.result.MaxLength = 8;
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(217, 51);
            this.result.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.result);
            this.Controls.Add(this.year_for_user);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Kunstler Script", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox year_for_user;
        private System.Windows.Forms.TextBox result;
    }
}

