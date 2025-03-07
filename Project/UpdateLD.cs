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

namespace Project
{
    public partial class UpdateLD : Form
    {
        public string TableUser { get; set; }
        public UpdateLD()
        {
            InitializeComponent();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            string FName = FirstName.Text;
            string LName = LastName.Text;
            string mail = Email.Text;
            string contact = Phone.Text;
            string uname = Username.Text;
            string pass = Password.Text;
            string dob = dateofbirth.Text;

            string connectionString = "Data Source=DESKTOP-KSANB9N\\SQLEXPRESS;Initial Catalog=\"TA/LD Management System\";Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "UPDATE Lab_Demonstrator SET FName = '" + FName + "', LName = '" + LName + "', Email = '" + mail + "', Phone = '" + contact + "', Pasword = '" + pass + "', dob = '" + dob + "' WHERE username = '" + uname + "'";
            SqlCommand command = new SqlCommand(query, connection);

            int rowsaffected = command.ExecuteNonQuery();
            if (rowsaffected > 0)
            {
                MessageBox.Show("Update Successful " + FName + LName);
                TADetails form4 = new TADetails();
                form4.TableUser = TableUser;
                form4.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Update Failed");
            }
            connection.Close();
        }

        private void backfromcreateaccount_Click(object sender, EventArgs e)
        {
            LDDetails details = new LDDetails();
            details.TableUser = TableUser;
            details.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UpdateLD_Load(object sender, EventArgs e)
        {

        }
    }
}
