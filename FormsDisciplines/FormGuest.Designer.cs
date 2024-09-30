namespace FormsDisciplines
{
    partial class FormGuest
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
            this.signInbutton1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernametext = new System.Windows.Forms.TextBox();
            this.passwordtext = new System.Windows.Forms.TextBox();
            this.Back_button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // signInbutton1
            // 
            this.signInbutton1.Location = new System.Drawing.Point(312, 248);
            this.signInbutton1.Name = "signInbutton1";
            this.signInbutton1.Size = new System.Drawing.Size(75, 23);
            this.signInbutton1.TabIndex = 0;
            this.signInbutton1.Text = "Sign in";
            this.signInbutton1.UseVisualStyleBackColor = true;
            this.signInbutton1.Click += new System.EventHandler(this.signInbutton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "password";
            // 
            // usernametext
            // 
            this.usernametext.Location = new System.Drawing.Point(280, 150);
            this.usernametext.Name = "usernametext";
            this.usernametext.Size = new System.Drawing.Size(239, 22);
            this.usernametext.TabIndex = 3;
            // 
            // passwordtext
            // 
            this.passwordtext.Location = new System.Drawing.Point(280, 200);
            this.passwordtext.Name = "passwordtext";
            this.passwordtext.Size = new System.Drawing.Size(239, 22);
            this.passwordtext.TabIndex = 4;
            // 
            // Back_button1
            // 
            this.Back_button1.Location = new System.Drawing.Point(666, 351);
            this.Back_button1.Name = "Back_button1";
            this.Back_button1.Size = new System.Drawing.Size(75, 23);
            this.Back_button1.TabIndex = 5;
            this.Back_button1.Text = "Back";
            this.Back_button1.UseVisualStyleBackColor = true;
            this.Back_button1.Click += new System.EventHandler(this.Back_button1_Click);
            // 
            // FormGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Back_button1);
            this.Controls.Add(this.passwordtext);
            this.Controls.Add(this.usernametext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signInbutton1);
            this.Name = "FormGuest";
            this.Text = "FormGuest";
            this.Load += new System.EventHandler(this.FormGuest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signInbutton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernametext;
        private System.Windows.Forms.TextBox passwordtext;
        private System.Windows.Forms.Button Back_button1;
    }
}