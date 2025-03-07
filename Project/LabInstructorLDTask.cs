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
    public partial class LabInstructorLDTask : Form
    {

        public string TableUser { get; set; }
        public int L_ID { get; set; }
        public int task_ID { get; set; }
        public LabInstructorLDTask()
        {
            InitializeComponent();
        }

        private void LabInstructorLDTask_Load(object sender, EventArgs e)
        {
            LoadCIntDetails();
            SetupDataGridViewColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void LoadCIntDetails()
        {
            string connectionString = "Data Source=DESKTOP-KSANB9N\\SQLEXPRESS;Initial Catalog=\"TA/LD Management System\";Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "exec LLDtasks " + L_ID;
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


        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                task_ID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Task ID"].Value);
                if (e.ColumnIndex == dataGridView1.Columns["Delete Task"].Index)
                {
                    DeleteTask();
                }

                if (e.ColumnIndex == dataGridView1.Columns["Update Task"].Index)
                {
                    UpdateTask();
                }

                LoadCIntDetails();
            }
        }

        private void SetupDataGridViewColumns()
        {
            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn();
            deleteColumn.Name = "Delete Task";
            deleteColumn.Text = "Delete Task";
            deleteColumn.UseColumnTextForButtonValue = true;

            DataGridViewButtonColumn updateColumn = new DataGridViewButtonColumn();
            updateColumn.Name = "Update Task";
            updateColumn.Text = "Update Task";
            updateColumn.UseColumnTextForButtonValue = true;

            dataGridView1.Columns.Add(updateColumn);
            dataGridView1.Columns.Add(deleteColumn);

        }

        private void DeleteTask()
        {
            string connectionString = "Data Source=DESKTOP-KSANB9N\\SQLEXPRESS;Initial Catalog=\"TA/LD Management System\";Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string deleteQuery = "DELETE FROM Lab_Tasks WHERE ID = @TaskID";
                SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                deleteCommand.Parameters.AddWithValue("@TaskID", task_ID);

                int rowsAffected = deleteCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Task Deleted");
                }
                else
                {
                    MessageBox.Show("Error Deleting Task");
                }

                connection.Close();
            }
        }

        private void UpdateTask()
        {
            LIUpdateTask up = new LIUpdateTask();
            up.TableUser = TableUser;
            up.task_ID = task_ID;
            up.L_ID = L_ID;
            up.Show();
            this.Hide();
        }


        private void AddTask_Click_1(object sender, EventArgs e)
        {
            AddLabTask act = new AddLabTask();
            act.TableUser = TableUser;
            act.L_ID = L_ID;
            act.Show();
            this.Hide();
        }

        private void backfromctsec_Click_1(object sender, EventArgs e)
        {
            LabInstructorView view = new LabInstructorView();
            view.L_ID = L_ID;
            view.TableUser = TableUser;
            view.Show();
            this.Hide();
        }

        
    }
}
