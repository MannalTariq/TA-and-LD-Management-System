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
    public partial class AddCourseTask : Form
    {

        public string TableUser { get; set; }
        public int task_ID { get; set; }
        public int C_ID { get; set; }
        public AddCourseTask()
        {
            InitializeComponent();
        }

        private void AddCourseTask_Load(object sender, EventArgs e)
        {
            LoadTADetails();
            TAinfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void backfromctsec_Click(object sender, EventArgs e)
        {
            CourseInstructorTATasks ct = new CourseInstructorTATasks();
            ct.C_ID = C_ID;
            ct.TableUser = TableUser;
            ct.task_ID = task_ID;
            ct.Show();
            this.Hide();
        }

        private void AddTask_Click(object sender, EventArgs e)
        {
            string TaskName = tName.Text;
            string Description = tdesc.Text;
            string DueDate = tdead.Text;
            string ta = TA.Text;
            string section = sec.Text;
            string connectionString = "Data Source=DESKTOP-KSANB9N\\SQLEXPRESS;Initial Catalog=\"TA/LD Management System\";Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            string query = "InsertCourseTask";

            using (SqlCommand command = new SqlCommand(query, con))
            {
                command.Parameters.AddWithValue("@TaskName", TaskName);
                command.Parameters.AddWithValue("@Description", Description);
                command.Parameters.AddWithValue("@DueDate", DueDate);
                command.Parameters.AddWithValue("@TA_ID", ta);
                command.Parameters.AddWithValue("@INT_ID", C_ID);
                command.Parameters.AddWithValue("@CSec_ID", section);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Task Added :" + TaskName);
                    CourseInstructorTATasks ct = new CourseInstructorTATasks();
                    ct.task_ID = task_ID;
                    ct.C_ID = C_ID;
                    ct.TableUser = TableUser;
                    ct.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sign Up Failed");
                }
            }

        }


        public void LoadTADetails()
        {
            string connectionString = "Data Source=DESKTOP-KSANB9N\\SQLEXPRESS;Initial Catalog=\"TA/LD Management System\";Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "exec TAGrid " + C_ID;
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            TAinfo.DataSource = dataTable;


            string teacherquery = "Select ID FROM Teacher WHERE Username = " + "'" + TableUser + "'";

            SqlCommand commandT = new SqlCommand(teacherquery, connection);
            SqlDataReader TAreader = commandT.ExecuteReader();

            if (TAreader.Read())
            {

                C_ID = Convert.ToInt32(TAreader["ID"]);

            }
            else
            {

                MessageBox.Show("C_ID ID not found.");
                return;
            }

            TAreader.Close();
            connection.Close();


        }

        private void TAinfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
