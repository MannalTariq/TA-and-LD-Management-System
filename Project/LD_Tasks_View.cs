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
    public partial class LD_Tasks_View : Form
    {

        public string TableUser { get; set; }

        public int LD_ID { get; set; }

        public LD_Tasks_View()
        {
            InitializeComponent();
            SetupDataGridViewColumns();
        }

        private void LD_Tasks_View_Load(object sender, EventArgs e)
        {
            LoadTaskData();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int taskId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Task ID"].Value);

                if (e.ColumnIndex == dataGridView1.Columns["Update Status"].Index)
                {
                    UpdateTaskStatus(taskId);


                }
            }

            LoadTaskData();
        }

        private void LoadTaskData()
        {

            string connectionString = "Data Source=DESKTOP-KSANB9N\\SQLEXPRESS;Initial Catalog=\"TA/LD Management System\";Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "exec LDTaskView " + LD_ID;
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            dataGridView1.Refresh();
            connection.Close();

        }


        private void SetupDataGridViewColumns()
        {
            DataGridViewButtonColumn statusColumn = new DataGridViewButtonColumn();
            statusColumn.Name = "Update Status";
            statusColumn.Text = "Mark Completed";
            statusColumn.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Add(statusColumn);
        }


        private void UpdateTaskStatus(int taskId)
        {
            
            string connectionString = "Data Source=DESKTOP-KSANB9N\\SQLEXPRESS;Initial Catalog=\"TA/LD Management System\";Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "UPDATE Lab_Tasks SET Status_ = 'Completed' WHERE ID = @TaskID";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TaskID", taskId);

            int rowsAffected = command.ExecuteNonQuery();

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
    }
}
