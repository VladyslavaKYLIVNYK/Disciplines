using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormsDisciplines
{
 

    public partial class FormStudent : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LRTS17K\SQLSERVER;Initial Catalog=kursova; User ID=UserVlada;Password=1234 ");
        public FormStudent()
        {
            InitializeComponent();
        }

        private void CreateColumns()
        {
           
            dataGridView1.Columns.Add("Disciplines_name", "Disciplines_name");
            dataGridView1.Columns.Add("Disciplines_description", "Disciplines_description");
            dataGridView1.Columns.Add("Kafedra_name", "Kafedra_name");
            dataGridView1.Columns.Add("Kafedra_description", "Kafedra_description");
            dataGridView1.Columns.Add("Teacher_pib", "Teacher_pib");
         
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0),     
            record.GetString(1), 
            record.GetString(2),  
            record.GetString(3),
            record.GetString(4));

            
        }

        private void RefreshDataGrid(DataGridView dgw)
        {

            dgw.Rows.Clear();

            string queryString = "SELECT Discipline.Disciplines_name, Discipline.Disciplines_description, Discipline.Kafedra_name, Discipline.Kafedra_description, Discipline.Teacher_pib FROM Discipline " +
                "JOIN Teacher ON Teacher.Teacher_id = Discipline.Disciplines_id;";


            SqlCommand command = new SqlCommand(queryString, conn);

            conn.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }
        
        private void Choice_button1_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Closed)
            {

                conn.Open();
            }

            string Disciplinename = DisNametextBox.Text; 

            if (string.IsNullOrWhiteSpace(Disciplinename))
            {
                MessageBox.Show("Введіть назву дисципліни!");
                return;
            }

            try
            {
                if (conn.State == ConnectionState.Closed)
                {

                    conn.Open();
                }
                SqlCommand command = new SqlCommand($"INSERT INTO [Report] (Disciplines_name) VALUES (@Disciplines_name)", conn);

                command.Parameters.AddWithValue("@Disciplines_name", DisNametextBox.Text);

                MessageBox.Show(command.ExecuteNonQuery().ToString());

                conn.Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Дисципліна успішно обрана і додана до таблиці!");
                    
                }
                else
                {
                    MessageBox.Show("Не вдалося додати дисципліну до таблиці.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");

            } finally {  

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Deletebutton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {

                    conn.Open();
                }
                SqlCommand command = new SqlCommand($"DELETE FROM [Report] WHERE Disciplines_name = @Disciplines_name", conn);
                command.Parameters.AddWithValue("@Disciplines_name", deletetextBox1.Text);

                MessageBox.Show(command.ExecuteNonQuery().ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");

            }
            finally
            {

                if (conn.State == ConnectionState.Open)
                {

                    conn.Close();
                }
            }
        }

        private void Exit_button1_Click(object sender, EventArgs e)
        {
            FormGuest formguest = new FormGuest();
            formguest.Show();
            this.Close();
        }
    }
}
