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
    public partial class LDAttendance : Form
    {
        public string TableUser { get; set; }
        public int LD_ID { get; set; }


        public LDAttendance()
        {
            InitializeComponent();
        }

      
        private void LDAttendance_Load(object sender, EventArgs e)
        {
            loadattendance();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void loadattendance()
        {
            string connectionString = "Data Source=DESKTOP-KSANB9N\\SQLEXPRESS;Initial Catalog=\"TA/LD Management System\";Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "exec LDattendanceView " + LD_ID;
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            connection.Close();
        }

        private void backfromLDView_Click(object sender, EventArgs e)
        {
            LabSec lab = new LabSec();
            lab.TableUser = TableUser;
            lab.LD_ID = LD_ID;
            lab.Show();
            this.Hide();
        }
    }

}
