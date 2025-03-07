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
    public partial class AddLabTask : Form
    {
        public string TableUser { get; set; }
        public int task_ID { get; set; }
        public int L_ID { get; set; }

        public AddLabTask()
        {
            InitializeComponent();
        }

        private void AddLabTask_Load(object sender, EventArgs e)
        {
            LoadLDDetails();
            LDinfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void LoadLDDetails()
        {
            string connectionString = "Data Source=DESKTOP-KSANB9N\\SQLEXPRESS;Initial Catalog=\"TA/LD Management System\";Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "exec LDGrid " + L_ID;
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            LDinfo.DataSource = dataTable;


            string teacherquery = "Select ID FROM Teacher WHERE Username = " + "'" + TableUser + "'";

            SqlCommand commandT = new SqlCommand(teacherquery, connection);
            SqlDataReader TAreader = commandT.ExecuteReader();

            if (TAreader.Read())
            {

                L_ID = Convert.ToInt32(TAreader["ID"]);

            }
            else
            {

                MessageBox.Show("L_ID ID not found.");
                return;
            }

            TAreader.Close();
            connection.Close();


        }

        private void AddTask_Click(object sender, EventArgs e)
        {
            string TaskName = tName.Text;
            string Description = tdesc.Text;
            string DueDate = tdead.Text;
            string ld = TA.Text;
            string section = sec.Text;
            string connectionString = "Data Source=DESKTOP-KSANB9N\\SQLEXPRESS;Initial Catalog=\"TA/LD Management System\";Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            //string query = "INSERT INTO Lab_Tasks (TName, TDescription, Deadline, LD_ID, INT_ID, LSec_ID) VALUES(@TaskName, @Description, @Deadline, @LD_ID, @INT_ID, @LSec_ID)";
            string query = "InsertLabTask";

            using (SqlCommand command = new SqlCommand(query, con))
            {
                command.Parameters.AddWithValue("@TaskName", TaskName);
                command.Parameters.AddWithValue("@Description", Description);
                command.Parameters.AddWithValue("@Deadline", DueDate);
                command.Parameters.AddWithValue("@LD_ID", ld);
                command.Parameters.AddWithValue("@INT_ID", L_ID);
                command.Parameters.AddWithValue("@LSec_ID", section);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Task Added :" + TaskName);
                    LabInstructorLDTask ct = new LabInstructorLDTask();
                    ct.task_ID = task_ID;
                    ct.L_ID = L_ID;
                    ct.TableUser = TableUser;
                    ct.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Adding Task Failed");
                }
            }

        }

        private void backfromctsec_Click(object sender, EventArgs e)
        {
            LabInstructorLDTask ct = new LabInstructorLDTask();
            ct.L_ID = L_ID;
            ct.TableUser = TableUser;
            ct.task_ID = task_ID;
            ct.Show();
            this.Hide();
        }
    }
}
