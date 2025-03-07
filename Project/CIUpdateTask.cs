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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project
{
    public partial class CIUpdateTask : Form
    {

        public string TableUser { get; set; }
        public int C_ID { get; set; }
        public int task_ID { get; set; }
        public CIUpdateTask()
        {
            InitializeComponent();
        }

        private void CIUpdateTask_Load(object sender, EventArgs e)
        {
        }


        private void backfromcreateaccount_Click(object sender, EventArgs e)
        {
            CourseInstructorTATasks ct = new CourseInstructorTATasks();
            ct.TableUser = TableUser;
            ct.C_ID = C_ID;
            ct.task_ID = task_ID;
            ct.Show();
            this.Hide();
        }

        //private void Update_Click(object sender, EventArgs e)
        //{
        //    string Name = tname.Text;
        //    string description = tdesc.Text;
        //    string deadline = tdead.Text;

        //    string connectionString = "Data Source=DESKTOP-KSANB9N\\SQLEXPRESS;Initial Catalog=\"TA/LD Management System\";Integrated Security=True";
        //    SqlConnection connection = new SqlConnection(connectionString);
        //    connection.Open();

        //    string query = "exec UpdateTask " + task_ID + " " + Name + " " + description + " " + deadline;
        //    SqlCommand command = new SqlCommand(query, connection);

        //    int rowsaffected = command.ExecuteNonQuery();
        //    if (rowsaffected > 0)
        //    {
        //        MessageBox.Show("Update Successful " + Name);
        //        CourseInstructorTATasks ct = new CourseInstructorTATasks();
        //        ct.TableUser = TableUser;
        //        ct.C_ID = C_ID;
        //        ct.task_ID = task_ID;
        //        ct.Show();
        //        this.Hide();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Update Failed");
        //    }
        //    connection.Close();
        //}

        private void Update_Click(object sender, EventArgs e)
        {
            string Name = tname.Text;
            string description = tdesc.Text;
            string deadline = tdead.Text;

            string connectionString = "Data Source=DESKTOP-KSANB9N\\SQLEXPRESS;Initial Catalog=\"TA/LD Management System\";Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "exec UpdateTask @tid, @tname, @tdesc, @td";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@tid", task_ID);
                command.Parameters.AddWithValue("@tname", Name);
                command.Parameters.AddWithValue("@tdesc", description);
                command.Parameters.AddWithValue("@td", deadline);

                int rowsaffected = command.ExecuteNonQuery();

                if (rowsaffected > 0)
                {
                    MessageBox.Show("Update Successful " + Name);
                    CourseInstructorTATasks ct = new CourseInstructorTATasks();
                    ct.TableUser = TableUser;
                    ct.C_ID = C_ID;
                    ct.task_ID = task_ID;
                    ct.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Update Failed");
                }

                connection.Close();
            }
        }


    }

}
