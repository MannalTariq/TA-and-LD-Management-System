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
    public partial class DeleteLD : Form
    {
        public string TableUser { get; set; }
        public DeleteLD()
        {
            InitializeComponent();
        }

        private void DeletaLD_Click(object sender, EventArgs e)
        {
            string FName = FirstName.Text;
            string LName = LastName.Text;
            string uname = Username.Text;
            string connectionString = "Data Source=DESKTOP-KSANB9N\\SQLEXPRESS;Initial Catalog=\"TA/LD Management System\";Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "DELETE FROM Lab_Demonstrator WHERE FName = '" + FName + "' and LName = '" + LName + "' and username = '" + uname + "';";
            SqlCommand command = new SqlCommand(query, con);

            int rowsaffected = command.ExecuteNonQuery();
            if (rowsaffected > 0)
            {
                MessageBox.Show("Lab Demonstrator Deleted :" + FName + " " + LName);
                LDDetails form4 = new LDDetails();
                form4.TableUser = TableUser;
                form4.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Deletion Failed");
            }
            con.Close();
        }

        private void backfromcreateaccount_Click(object sender, EventArgs e)
        {
            LDDetails details = new LDDetails();
            details.TableUser = TableUser;
            details.Show();
            this.Hide();
        }

        private void DeleteLD_Load(object sender, EventArgs e)
        {

        }
    }
}
