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
    public partial class LabInstructorLD : Form
    {
        public string TableUser { get; set; }
        public int L_ID { get; set; }
        public LabInstructorLD()
        {
            InitializeComponent();
        }

        private void LabInstructorLD_Load(object sender, EventArgs e)
        {
            LoadCIntDetails();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void LoadCIntDetails()
        {
            string connectionString = "Data Source=DESKTOP-KSANB9N\\SQLEXPRESS;Initial Catalog=\"TA/LD Management System\";Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = " exec LLDemonstrator " + L_ID;
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;


            string Cquery = "Select ID FROM Teacher WHERE Username = " + "'" + TableUser + "' AND typ = 'Lab Instructor'";

            SqlCommand commandT = new SqlCommand(Cquery, connection);
            SqlDataReader Creader = commandT.ExecuteReader();

            if (Creader.Read())
            {

                L_ID = Convert.ToInt32(Creader["ID"]);

            }
            else
            {

                MessageBox.Show("L_ID not found.");
                return;
            }

            Creader.Close();
            connection.Close();

        }

        private void backfromctLD_Click(object sender, EventArgs e)
        {
            LabInstructorView ct = new LabInstructorView();
            ct.L_ID = L_ID;
            ct.TableUser = TableUser;
            ct.Show();
            this.Hide();
        }
    }
}
