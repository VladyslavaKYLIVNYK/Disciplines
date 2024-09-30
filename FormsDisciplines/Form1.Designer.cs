namespace FormsDisciplines
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
            this.SignIn_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lebel2 = new System.Windows.Forms.Label();
            this.UserNametextBox = new System.Windows.Forms.TextBox();
            this.PasswordtextBox = new System.Windows.Forms.TextBox();
            this.Admin = new System.Windows.Forms.Label();
            this.Guest_button1 = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SignIn_button
            // 
            this.SignIn_button.Location = new System.Drawing.Point(327, 243);
            this.SignIn_button.Name = "SignIn_button";
            this.SignIn_button.Size = new System.Drawing.Size(75, 23);
            this.SignIn_button.TabIndex = 0;
            this.SignIn_button.Text = " Sign in";
            this.SignIn_button.UseVisualStyleBackColor = true;
            this.SignIn_button.Click += new System.EventHandler(this.SignIn_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // lebel2
            // 
            this.lebel2.AutoSize = true;
            this.lebel2.Location = new System.Drawing.Point(146, 185);
            this.lebel2.Name = "lebel2";
            this.lebel2.Size = new System.Drawing.Size(67, 16);
            this.lebel2.TabIndex = 3;
            this.lebel2.Text = "Password";
            // 
            // UserNametextBox
            // 
            this.UserNametextBox.Location = new System.Drawing.Point(238, 131);
            this.UserNametextBox.Name = "UserNametextBox";
            this.UserNametextBox.Size = new System.Drawing.Size(260, 22);
            this.UserNametextBox.TabIndex = 4;
            // 
            // PasswordtextBox
            // 
            this.PasswordtextBox.Location = new System.Drawing.Point(238, 182);
            this.PasswordtextBox.Name = "PasswordtextBox";
            this.PasswordtextBox.Size = new System.Drawing.Size(260, 22);
            this.PasswordtextBox.TabIndex = 5;
            // 
            // Admin
            // 
            this.Admin.AutoSize = true;
            this.Admin.Location = new System.Drawing.Point(344, 98);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(45, 16);
            this.Admin.TabIndex = 6;
            this.Admin.Text = "Admin";
            // 
            // Guest_button1
            // 
            this.Guest_button1.Location = new System.Drawing.Point(609, 26);
            this.Guest_button1.Name = "Guest_button1";
            this.Guest_button1.Size = new System.Drawing.Size(154, 31);
            this.Guest_button1.TabIndex = 7;
            this.Guest_button1.Text = "Guest";
            this.Guest_button1.UseVisualStyleBackColor = true;
            this.Guest_button1.Click += new System.EventHandler(this.Guest_button1_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.Location = new System.Drawing.Point(104, 365);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(75, 23);
            this.Exit_button.TabIndex = 8;
            this.Exit_button.Text = "Exit";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.Guest_button1);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.PasswordtextBox);
            this.Controls.Add(this.UserNametextBox);
            this.Controls.Add(this.lebel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SignIn_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SignIn_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lebel2;
        private System.Windows.Forms.TextBox UserNametextBox;
        private System.Windows.Forms.TextBox PasswordtextBox;
        private System.Windows.Forms.Label Admin;
        private System.Windows.Forms.Button Guest_button1;
        private System.Windows.Forms.Button Exit_button;
    }
}

