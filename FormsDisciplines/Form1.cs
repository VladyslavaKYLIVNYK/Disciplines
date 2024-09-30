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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-LRTS17K\SQLSERVER;Initial Catalog=kursova; User ID=UserVlada;Password=1234 ");
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SignIn_button_Click(object sender, EventArgs e)
        {
            String username, password;
            username = UserNametextBox.Text;
            password = PasswordtextBox.Text;

            try
            {
                String querry = "SELECT * FROM SignInA WHERE username ='" + UserNametextBox.Text + "' AND password = '" + PasswordtextBox.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);


                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    MessageBox.Show("Login successful");

                    username = UserNametextBox.Text;
                    password = PasswordtextBox.Text;

                    
                    FormAdmin form2 = new FormAdmin();
                    form2.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid login or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UserNametextBox.Clear();
                    PasswordtextBox.Clear();

                    
                    UserNametextBox.Focus();

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

        private void Exit_button_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }

        }

        private void Guest_button1_Click(object sender, EventArgs e)
        {
            FormGuest formGuest = new FormGuest();
            formGuest.Show();
            this.Hide();

        }
    }
}
