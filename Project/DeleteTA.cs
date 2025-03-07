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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project
{
    public partial class DeleteTA : Form
    {
        public string TableUser { get; set; }
        public DeleteTA()
        {
            InitializeComponent();
        }

        private void backfromcreateaccount_Click(object sender, EventArgs e)
        {
            TADetails details = new TADetails();
            details.TableUser = TableUser;
            details.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void LastName_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void FirstName_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void DeleteTA_Click(object sender, EventArgs e)
        {
            string FName = FirstName.Text;
            string LName = LastName.Text;
            string uname = Username.Text;
            string connectionString = "Data Source=DESKTOP-KSANB9N\\SQLEXPRESS;Initial Catalog=\"TA/LD Management System\";Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "DELETE FROM Teacher_Assistant WHERE FName = '" + FName + "' and LName = '" + LName + "' and username = '"+ uname + "';";
            SqlCommand command = new SqlCommand(query, con);

            int rowsaffected = command.ExecuteNonQuery();
            if (rowsaffected > 0)
            {
                MessageBox.Show("Teacher Assistant Deleted :" + FName + " " + LName);
                TADetails form4 = new TADetails();
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

        private void DeleteTA_Load(object sender, EventArgs e)
        {

        }
    }
}
