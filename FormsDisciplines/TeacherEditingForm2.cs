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
    public partial class TeacherEditingForm2 : Form
    {
        public TeacherEditingForm2()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LRTS17K\SQLSERVER;Initial Catalog=kursova; User ID=UserVlada;Password=1234 ");
        private void AddTeacherbutton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {

                    conn.Open();
                }

                SqlCommand command = new SqlCommand($"INSERT INTO [Discipline] (Disciplines_name, Disciplines_description, Kafedra_name, Teacher_pib) VALUES (@Disciplines_name, @Disciplines_description, @Kafedra_name, @Teacher_pib)", conn);

                command.Parameters.AddWithValue("@Disciplines_name", textBox1.Text);
                command.Parameters.AddWithValue("@Disciplines_description", textBox2.Text);
                command.Parameters.AddWithValue("@Kafedra_name", textBox3.Text);
                command.Parameters.AddWithValue("@Teacher_pib", textBox4.Text);
               


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

        private void DeleteTeacherbutton2_Click(object sender, EventArgs e) 
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {

                    conn.Open();
                }

                SqlCommand command = new SqlCommand($"DELETE FROM [Discipline] WHERE Disciplines_name = @Disciplines_name AND Disciplines_description = @Disciplines_description AND Kafedra_name = @Kafedra_name AND Teacher_pib = @Teacher_pib", conn);
                command.Parameters.AddWithValue("@Disciplines_name", textBox1.Text);
                command.Parameters.AddWithValue("@Disciplines_description", textBox2.Text);
                command.Parameters.AddWithValue("@Kafedra_name", textBox3.Text);
                command.Parameters.AddWithValue("@Teacher_pib", textBox4.Text);


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

        private void button1_Click(object sender, EventArgs e)
        {
            FormTeacher formTeacher = new FormTeacher();
            formTeacher.Show();
            this.Close();
        }

        private void TeacherEditingForm2_Load(object sender, EventArgs e)
        {

        }
    }
}
