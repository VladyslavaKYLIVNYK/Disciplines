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
    public partial class FormGuest : Form
    {
        public FormGuest()
        {
            InitializeComponent();
        }

        private void FormGuest_Load(object sender, EventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LRTS17K\SQLSERVER;Initial Catalog=kursova; User ID=UserVlada;Password=1234 ");

        private void signInbutton1_Click(object sender, EventArgs e)
        {
            String username, password;
            username = usernametext.Text;
            password = passwordtext.Text;


            try
            {
                String querry = "SELECT * FROM USERS WHERE username ='" + usernametext.Text + "' AND password = '" + passwordtext.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);


                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    MessageBox.Show("Login successful");

                    if (username == "student" && password == "student")
                    {
                        FormStudent form4 = new FormStudent();
                        form4.Show();
                        
                    }
                    else if (username == "teacher" && password == "teacher")
                    {
                        FormTeacher form5 = new FormTeacher();
                        form5.Show();
                       
                    }
                }
                else
                {
                    MessageBox.Show("Invalid login or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //to focus
                    usernametext.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void Back_button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
            
        }
    }
}
