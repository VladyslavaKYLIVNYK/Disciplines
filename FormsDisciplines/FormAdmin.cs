using FormsDisciplines;
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

namespace Disciplines
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LRTS17K\SQLSERVER;Initial Catalog=kursova; User ID=UserVlada;Password=1234 ");
        private void FormAdmin_Load(object sender, EventArgs e)
        {
            CreateColumns2();
            RefreshDataGrid2(AdmindataGridView);
            CountDisciplines();
            CountTeacher();
        }

        private void Add_button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {

                    conn.Open();
                }

                SqlCommand command = new SqlCommand($"INSERT INTO [Discipline] (Disciplines_name, Disciplines_description, Kafedra_name, Kafedra_description, Teacher_pib) VALUES (@Disciplines_name, @Disciplines_description, @Kafedra_name, @Kafedra_description, @Teacher_pib)", conn);

                command.Parameters.AddWithValue("@Disciplines_name", textBox1.Text);
                command.Parameters.AddWithValue("@Disciplines_description", textBox3.Text);
                command.Parameters.AddWithValue("@Kafedra_name", textBox4.Text);
                command.Parameters.AddWithValue("@Kafedra_description", textBox5.Text);
                command.Parameters.AddWithValue("@Teacher_pib", textBox6.Text);

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

        private void Delete_button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (conn.State == ConnectionState.Closed)
                {

                    conn.Open();
                }
                SqlCommand command = new SqlCommand($"DELETE FROM [Discipline] WHERE Disciplines_name = @Disciplines_name", conn);
                command.Parameters.AddWithValue("@Disciplines_name", textBox2.Text);

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

        private void CreateColumns2()
        {
            
            AdmindataGridView.Columns.Add("Disciplines_name", "Disciplines_name");
            AdmindataGridView.Columns.Add("Disciplines_description", "Disciplines_description");
            AdmindataGridView.Columns.Add("Kafedra_name", "Kafedra_name");
            AdmindataGridView.Columns.Add("Kafedra_description", "Kafedra_description");
            AdmindataGridView.Columns.Add("Teacher_pib", "Teacher_pib");

        }

        private void ReadSingleRow2(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetString(0), 
            record.GetString(1),   
            record.GetString(2),   
            record.GetString(3),
            record.GetString(4));

        }

        private void RefreshDataGrid2(DataGridView dgw)
        {

            dgw.Rows.Clear();

            string queryString = "SELECT Discipline.Disciplines_name, Discipline.Disciplines_description, Discipline.Kafedra_name, Discipline.Kafedra_description, Discipline.Teacher_pib FROM Discipline " +
                "JOIN Teacher ON Teacher.Teacher_id = Discipline.Disciplines_id;";


            SqlCommand command = new SqlCommand(queryString, conn);

            conn.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow2(dgw, reader);
            }
            reader.Close();
        }

        private void ReportStbutton1_Click(object sender, EventArgs e)
        {
            ChoiceDisStud choiceDisStud = new ChoiceDisStud();
            choiceDisStud.Show();
            this.Close();   
           
        }

        private void TexitAdbutton1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
            
        }

        private void CountDisciplines()
        {
            if (conn.State == ConnectionState.Closed)
            {

                conn.Open();
            }
            
            string sql = "SELECT COUNT(*) FROM Discipline";

            SqlCommand command = new SqlCommand(sql, conn);

            // Використовуємо ExecuteScalar для отримання єдиного значення (кількості дисциплін)
            int count = Convert.ToInt32(command.ExecuteScalar());

            MessageBox.Show($"Кількість дисциплін: {count}");

        }
        private void CountTeacher()
        {
            if (conn.State == ConnectionState.Closed)
            {

                conn.Open();
            }

            string sql = "SELECT COUNT(*) FROM Teacher";

            SqlCommand command = new SqlCommand(sql, conn);

            int count = (int)command.ExecuteScalar();


            MessageBox.Show($"Кількість викладачів: {count}");


            conn.Close();



        }
    }
}
