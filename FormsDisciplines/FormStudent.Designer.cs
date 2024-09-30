namespace FormsDisciplines
{
    partial class FormStudent
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
            this.Choice_button1 = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DisNametextBox = new System.Windows.Forms.TextBox();
            this.Deletebutton1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.deletetextBox1 = new System.Windows.Forms.TextBox();
            this.Exit_button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Choice_button1
            // 
            this.Choice_button1.Location = new System.Drawing.Point(477, 390);
            this.Choice_button1.Name = "Choice_button1";
            this.Choice_button1.Size = new System.Drawing.Size(75, 23);
            this.Choice_button1.TabIndex = 0;
            this.Choice_button1.Text = "Choice";
            this.Choice_button1.UseVisualStyleBackColor = true;
            this.Choice_button1.Click += new System.EventHandler(this.Choice_button1_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(89, 394);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(103, 16);
            this.name.TabIndex = 1;
            this.name.Text = "Discipline name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(83, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(965, 322);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DisNametextBox
            // 
            this.DisNametextBox.Location = new System.Drawing.Point(198, 391);
            this.DisNametextBox.Name = "DisNametextBox";
            this.DisNametextBox.Size = new System.Drawing.Size(256, 22);
            this.DisNametextBox.TabIndex = 4;
            // 
            // Deletebutton1
            // 
            this.Deletebutton1.Location = new System.Drawing.Point(477, 434);
            this.Deletebutton1.Name = "Deletebutton1";
            this.Deletebutton1.Size = new System.Drawing.Size(75, 23);
            this.Deletebutton1.TabIndex = 5;
            this.Deletebutton1.Text = "Delete";
            this.Deletebutton1.UseVisualStyleBackColor = true;
            this.Deletebutton1.Click += new System.EventHandler(this.Deletebutton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Discipline name";
            // 
            // deletetextBox1
            // 
            this.deletetextBox1.Location = new System.Drawing.Point(198, 434);
            this.deletetextBox1.Name = "deletetextBox1";
            this.deletetextBox1.Size = new System.Drawing.Size(256, 22);
            this.deletetextBox1.TabIndex = 7;
            // 
            // Exit_button1
            // 
            this.Exit_button1.Location = new System.Drawing.Point(1050, 501);
            this.Exit_button1.Name = "Exit_button1";
            this.Exit_button1.Size = new System.Drawing.Size(75, 23);
            this.Exit_button1.TabIndex = 8;
            this.Exit_button1.Text = "Exit";
            this.Exit_button1.UseVisualStyleBackColor = true;
            this.Exit_button1.Click += new System.EventHandler(this.Exit_button1_Click);
            // 
            // FormStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 563);
            this.Controls.Add(this.Exit_button1);
            this.Controls.Add(this.deletetextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Deletebutton1);
            this.Controls.Add(this.DisNametextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.Choice_button1);
            this.Name = "FormStudent";
            this.Text = "FormStudent";
            this.Load += new System.EventHandler(this.FormStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Choice_button1;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox DisNametextBox;
        private System.Windows.Forms.Button Deletebutton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox deletetextBox1;
        private System.Windows.Forms.Button Exit_button1;
    }
}