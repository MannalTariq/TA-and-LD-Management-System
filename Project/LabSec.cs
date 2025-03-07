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
    public partial class LabSec : Form
    {
        public string TableUser { get; set; }
        public int LD_ID { get; set; }
        public LabSec()
        {
            InitializeComponent();
        }

        private void LabSec_Load(object sender, EventArgs e)
        {
            SetupDataGridViewColumns();
            LoadLDCourseSectionDetails();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadLDCourseSectionDetails()
        {
            string connectionString = "Data Source=DESKTOP-KSANB9N\\SQLEXPRESS;Initial Catalog=\"TA/LD Management System\";Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "exec labsectionview " + LD_ID;
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            connection.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ViewAttendance();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void backfromLDView_Click(object sender, EventArgs e)
        {
            LDView ld = new LDView();

            ld.LD_ID = LD_ID;
            ld.TableUser = TableUser;
          
            ld.LoadLDDetails();
            ld.Show();
            this.Hide();

        }

        private void SetupDataGridViewColumns()
        {
            DataGridViewButtonColumn AttendanceColumn = new DataGridViewButtonColumn();
            AttendanceColumn.Name = " ";
            AttendanceColumn.Text = "View Attendance";
            AttendanceColumn.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Add(AttendanceColumn);
        }

        private void ViewAttendance()
        {

            LDAttendance ld = new LDAttendance();
            ld.TableUser = TableUser;
            ld.LD_ID = LD_ID;
            ld.Show();
            this.Hide();
        }

    }
}
