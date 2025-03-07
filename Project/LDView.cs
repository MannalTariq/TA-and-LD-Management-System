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
    public partial class LDView : Form
    {
        public string TableUser { get; set; }
        public int LD_ID { get; set; }
      

        private LD_Tasks_View form;

        public LDView()
        {
            InitializeComponent();
        }

        private void backfromLDView_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            this.Hide();
        }


        public void LoadLDDetails()
        {
            string connectionString = "Data Source=DESKTOP-KSANB9N\\SQLEXPRESS;Initial Catalog=\"TA/LD Management System\";Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT concat(FName, ' ' ,LName) as Name,Email,Phone, DOB  FROM  Lab_Demonstrator where username =" + "'" + TableUser + "'";
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            string LDquery = "Select LD_ID FROM Lab_Demonstrator WHERE Username = " + "'" + TableUser + "'";

            SqlCommand commandT = new SqlCommand(LDquery, connection);
            SqlDataReader LDreader = commandT.ExecuteReader();

            if (LDreader.Read())
            {

                LD_ID = Convert.ToInt32(LDreader["LD_ID"]);

            }
            else
            {

                MessageBox.Show("LD ID not found.");
                return;
            }

            LDreader.Close();
            connection.Close();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LDView_Load(object sender, EventArgs e)
        {
            LoadLDDetails();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void viewTask_Click(object sender, EventArgs e)
        {
            form = new LD_Tasks_View();
            form.TableUser = TableUser;
            form.LD_ID = LD_ID;
            form.Show();

            this.Hide();
        }

        private void viewSection_Click(object sender, EventArgs e)
        {
            LabSec labs= new LabSec();
            labs.LD_ID = LD_ID;
            labs.TableUser = TableUser;
            labs.Show();
            this.Hide();
        }

        private void viewSalary_Click(object sender, EventArgs e)
        {
            LD_Salary sal = new LD_Salary();
            sal.LD_ID = LD_ID;
            sal.TableUser = TableUser;
            sal.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }

}
