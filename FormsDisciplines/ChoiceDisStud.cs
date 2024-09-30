using Disciplines;
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

namespace FormsDisciplines 
{
    public partial class ChoiceDisStud : Form
    {
        public ChoiceDisStud()
        {
            InitializeComponent();
        }

        private void backbutton1_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
         
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LRTS17K\SQLSERVER;Initial Catalog=kursova; User ID=UserVlada;Password=1234 ");
        private void CreateColumns2()
        {
            dataGridView1.Columns.Add("Student_surname", "Student_surname");
            dataGridView1.Columns.Add("Student_name", "Student_name");
            dataGridView1.Columns.Add("Student_patronymic", "Student_patronymic");
            dataGridView1.Columns.Add("Student_kurs", "Student_kurs");
            dataGridView1.Columns.Add("Disciplines_name", "Disciplines_name");
            dataGridView1.Columns.Add("Disciplines_id", "Disciplines_id");
            dataGridView1.Columns.Add("Student_id", "Student_id");

        }

        private void ReadSingleRow2(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0),   
            record.GetString(1), 
            record.GetString(2),
            record.GetInt32(3),
            record.GetString(4),
            record.GetInt32(5),
            record.GetInt32(6));

        }

        private void RefreshDataGrid2(DataGridView dgw)
        {
           
            dgw.Rows.Clear();

            string sql = "SELECT Student.Student_surname, Student.Student_name, Student.Student_patronymic, Student.Student_kurs, Discipline.Disciplines_name, Discipline.Disciplines_id, Student.Student_id FROM Student " +
    "JOIN Discipline ON Student.Student_id = Discipline.Disciplines_id";


            SqlCommand command = new SqlCommand(sql, conn);

            conn.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow2(dgw, reader);
            }
            reader.Close();
        }



        private void ChoiceDisStud_Load(object sender, EventArgs e)
        {
            CreateColumns2();
            RefreshDataGrid2(dataGridView1);
        }

        private void AddInfbutton1_Click(object sender, EventArgs e) //?
        {
            string Student_surname = textBox1.Text;
            string Student_name = textBox2.Text;
            string Student_patronymic = textBox3.Text;
            string Student_kurs = textBox4.Text;
            string Disciplines_name = textBox5.Text;
            string Disciplines_id = textBox6.Text;
            string Student_id = textBox7.Text;
         
            try
            {
                if (conn.State == ConnectionState.Closed)
                {

                    conn.Open();
                }
                SqlCommand command = new SqlCommand($"INSERT INTO [Report] (Student_surname, Student_name, Student_patronymic,Student_kurs,Disciplines_name,Disciplines_id, Student_id FROM Student " +
                   "JOIN Discipline ON Student.Student_id = Discipline.Disciplines_id) VALUES (@Student_surname, @Student_name, @Student_patronymic, @Student_kurs, @Disciplines_name, @Disciplines_id, @Student_id) ", conn);

                command.Parameters.AddWithValue("@Student_surname", Student_surname);
                command.Parameters.AddWithValue("@Student_name", Student_name);
                command.Parameters.AddWithValue("@Student_patronymic", Student_patronymic);
                command.Parameters.AddWithValue("@Student_kurs", Student_kurs);
                command.Parameters.AddWithValue("@Disciplines_name", Disciplines_name);
                command.Parameters.AddWithValue("@Disciplines_id", Disciplines_id);
                command.Parameters.AddWithValue("@Student_id", Student_id);

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

            }
            finally
            {

                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
           
        }
    }
}
