namespace FormsDisciplines
{
    partial class FormTeacher
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
            this.yourDataGridView = new System.Windows.Forms.DataGridView();
            this.HomeTeacherbutton1 = new System.Windows.Forms.Button();
            this.Backbutton1 = new System.Windows.Forms.Button();
            this.Editingbutton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.yourDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // yourDataGridView
            // 
            this.yourDataGridView.AllowUserToAddRows = false;
            this.yourDataGridView.AllowUserToDeleteRows = false;
            this.yourDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.yourDataGridView.Location = new System.Drawing.Point(31, 61);
            this.yourDataGridView.Name = "yourDataGridView";
            this.yourDataGridView.ReadOnly = true;
            this.yourDataGridView.RowHeadersWidth = 51;
            this.yourDataGridView.RowTemplate.Height = 24;
            this.yourDataGridView.Size = new System.Drawing.Size(757, 308);
            this.yourDataGridView.TabIndex = 0;
            this.yourDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // HomeTeacherbutton1
            // 
            this.HomeTeacherbutton1.Location = new System.Drawing.Point(31, 12);
            this.HomeTeacherbutton1.Name = "HomeTeacherbutton1";
            this.HomeTeacherbutton1.Size = new System.Drawing.Size(160, 32);
            this.HomeTeacherbutton1.TabIndex = 1;
            this.HomeTeacherbutton1.Text = "Home";
            this.HomeTeacherbutton1.UseVisualStyleBackColor = true;
            // 
            // Backbutton1
            // 
            this.Backbutton1.Location = new System.Drawing.Point(713, 393);
            this.Backbutton1.Name = "Backbutton1";
            this.Backbutton1.Size = new System.Drawing.Size(75, 23);
            this.Backbutton1.TabIndex = 2;
            this.Backbutton1.Text = "Back";
            this.Backbutton1.UseVisualStyleBackColor = true;
            this.Backbutton1.Click += new System.EventHandler(this.Backbutton1_Click);
            // 
            // Editingbutton1
            // 
            this.Editingbutton1.Location = new System.Drawing.Point(220, 12);
            this.Editingbutton1.Name = "Editingbutton1";
            this.Editingbutton1.Size = new System.Drawing.Size(158, 32);
            this.Editingbutton1.TabIndex = 3;
            this.Editingbutton1.Text = "Editing";
            this.Editingbutton1.UseVisualStyleBackColor = true;
            this.Editingbutton1.Click += new System.EventHandler(this.Editingbutton1_Click);
            // 
            // FormTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Editingbutton1);
            this.Controls.Add(this.Backbutton1);
            this.Controls.Add(this.HomeTeacherbutton1);
            this.Controls.Add(this.yourDataGridView);
            this.Name = "FormTeacher";
            this.Text = "FormTeacher";
            this.Load += new System.EventHandler(this.FormTeacher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.yourDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView yourDataGridView;
        private System.Windows.Forms.Button HomeTeacherbutton1;
        private System.Windows.Forms.Button Backbutton1;
        private System.Windows.Forms.Button Editingbutton1;
    }
}