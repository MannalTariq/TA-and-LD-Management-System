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
    public partial class AttendanceView : Form
    {
        public string TableUser { get; set; }
        public int L_ID { get; set; }
        public int LSec_ID { get; set; }
        public int LD_ID { get; set; }
        public AttendanceView()
        {
            InitializeComponent();

            SetupDataGridViewColumns();
        }

        private void AttendanceView_Load(object sender, EventArgs e)
        {
            LoadLIntDetails();
            AttendanceGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void SetupDataGridViewColumns()
        {
            DataGridViewButtonColumn statusColumn = new DataGridViewButtonColumn();
            statusColumn.Name = "Attendance";
            statusColumn.Text = "View Attendance";
            statusColumn.UseColumnTextForButtonValue = true;

            AttendanceGrid.Columns.Add(statusColumn);
        }

        private void viewLD_Click(object sender, EventArgs e)
        {

        }

        private void viewSection_Click(object sender, EventArgs e)
        {

        }

        private void viewTasks_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void AttendanceGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (AttendanceGrid.Rows[e.RowIndex].Cells["LD_ID"].Value != DBNull.Value)
                {
                    LD_ID = Convert.ToInt32(AttendanceGrid.Rows[e.RowIndex].Cells["LD_ID"].Value);
                }
                else
                {
                    MessageBox.Show("Error");
                    return;
                }

                if (AttendanceGrid.Rows[e.RowIndex].Cells["LSec_ID"].Value != DBNull.Value)
                {
                    LSec_ID = Convert.ToInt32(AttendanceGrid.Rows[e.RowIndex].Cells["LSec_ID"].Value);
                }
                else
                {
                    MessageBox.Show("Error!");
                    return;
                }

                if (e.ColumnIndex == AttendanceGrid.Columns["Attendance"].Index)
                {
                    Attendance ad = new Attendance();
                    ad.TableUser = TableUser;
                    ad.LD_ID = LD_ID;
                    ad.L_ID = L_ID;
                    ad.LSec_ID = LSec_ID;
                    ad.Show();
                    this.Hide();
                }
            }

            LoadLIntDetails();
        }


        public void LoadLIntDetails()
        {
            string connectionString = "Data Source=DESKTOP-KSANB9N\\SQLEXPRESS;Initial Catalog=\"TA/LD Management System\";Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = " exec LLDemonstrator " + L_ID;
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            AttendanceGrid.DataSource = dataTable;


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

        private void backfromattendance_Click(object sender, EventArgs e)
        {
            LabInstructorView liv = new LabInstructorView();
            liv.TableUser = TableUser;
            liv.L_ID = L_ID;
            liv.Show();
            this.Hide();
        }
    }
}
