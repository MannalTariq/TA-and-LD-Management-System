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
    public partial class CourseInstructorTATasks : Form
    {
        public string TableUser { get; set; }
        public int C_ID { get; set; }
        public int task_ID { get; set; }

        public CourseInstructorTATasks()
        {
            InitializeComponent();
        }

        private void CourseInstructorTATasks_Load(object sender, EventArgs e)
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

            string query = "exec ctatasks " + C_ID;
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;


            string Cquery = "Select ID FROM Teacher WHERE Username = " + "'" + TableUser + "' AND typ = 'Course Instructor'";

            SqlCommand commandT = new SqlCommand(Cquery, connection);
            SqlDataReader Creader = commandT.ExecuteReader();

            if (Creader.Read())
            {

                C_ID = Convert.ToInt32(Creader["ID"]);

            }
            else
            {

                MessageBox.Show("C_ID not found.");
                return;
            }

            Creader.Close();
            connection.Close();

        }

        private void backfromctsec_Click(object sender, EventArgs e)
        {
            CourseInstructorView view = new CourseInstructorView(); 
            view.C_ID = C_ID;
            view.TableUser = TableUser;
            view.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

                //string checkCompletionQuery = "SELECT Status_ FROM Course_Tasks WHERE ID = @TaskID";
                //SqlCommand checkCompletionCommand = new SqlCommand(checkCompletionQuery, connection);
                //checkCompletionCommand.Parameters.AddWithValue("@TaskID", task_ID);

                //string status = checkCompletionCommand.ExecuteScalar() as string;

                //if (status != null && status.Equals("Completed"))
                //{
                    string deleteQuery = "DELETE FROM Course_Tasks WHERE ID = @TaskID";
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
                //}
                //else
                //{
                //    MessageBox.Show("Task must be completed before deletion");
                //}

                connection.Close();
            }
        }

        private void UpdateTask()
        {
            CIUpdateTask up = new CIUpdateTask();
            up.TableUser = TableUser;
            up.task_ID = task_ID;
            up.C_ID = C_ID;
            up.Show();
            this.Hide();

            
        }

        private void AddTask_Click(object sender, EventArgs e)
        {
            AddCourseTask act = new AddCourseTask();
            act.TableUser = TableUser;
            act.C_ID = C_ID;
            act.Show();
            this.Hide();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
