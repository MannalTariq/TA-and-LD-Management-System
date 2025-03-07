using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class CourseSec : Form
    {

        public string TableUser { get; set; }
        public int TA_ID { get; set; }

        public CourseSec()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CourseSec_Load(object sender, EventArgs e)
        {
            LoadTACourseSectionDetails();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void LoadTACourseSectionDetails()
        {
            string connectionString = "Data Source=DESKTOP-KSANB9N\\SQLEXPRESS;Initial Catalog=\"TA/LD Management System\";Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "exec coursesectionview "+ TA_ID;
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            connection.Close();
        }

        private void backfromTAView_Click(object sender, EventArgs e)
        {
            TAView ta = new TAView();

            ta.TA_ID = TA_ID;
            ta.TableUser = TableUser;

            ta.LoadTADetails();
            ta.Show();
            this.Hide();
        }
    }
}
