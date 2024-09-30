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
   
    public partial class FormTeacher : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LRTS17K\SQLSERVER;Initial Catalog=kursova; User ID=UserVlada;Password=1234 ");
        public FormTeacher()
        {
            InitializeComponent();
        }

        private void CountStudent()
        {
            if (conn.State == ConnectionState.Closed)
            {

                conn.Open();
            }

            string sql = "SELECT COUNT(*) FROM Student";

            SqlCommand command = new SqlCommand(sql, conn);

            int count = (int)command.ExecuteScalar();


            MessageBox.Show($"Кількість студентів: {count}");


            conn.Close();


        }

        private void CreateColumns()
        {
            yourDataGridView.Columns.Add("Disciplines_id", "Disciplines_id");
            yourDataGridView.Columns.Add("Disciplines_name", "Disciplines_name");
            yourDataGridView.Columns.Add("Disciplines_description", "Disciplines_description");
            yourDataGridView.Columns.Add("Kafedra_id", "Kafedra_id");
            yourDataGridView.Columns.Add("Kafedra_name", "Kafedra_name");
            yourDataGridView.Columns.Add("Kafedra_description", "Kafedra_description");

            
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
              dgw.Rows.Add(record.GetInt32(0), 
              record.GetString(1),   
              record.GetString(2),  
              record.GetInt32(3),
              record.GetString(4),
              record.GetString(5));
                                  
        }

        private void RefreshDataGrid(DataGridView dgw)
        {

            dgw.Rows.Clear();

            string queryString = "SELECT Discipline.Disciplines_id, Discipline.Disciplines_name, Discipline.Disciplines_description, Discipline.Kafedra_id, Discipline.Kafedra_name, Discipline.Kafedra_description FROM Discipline " +
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
       

        private void FormTeacher_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(yourDataGridView);
            CountStudent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Backbutton1_Click(object sender, EventArgs e)
        {
            FormGuest formguest = new FormGuest();
            formguest.Show();
        }

        private void Editingbutton1_Click(object sender, EventArgs e)
        {
            TeacherEditingForm2 teacherEditingForm2 = new TeacherEditingForm2();
            teacherEditingForm2.Show();
        }
    }
}
