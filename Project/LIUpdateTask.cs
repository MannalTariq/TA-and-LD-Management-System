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
    public partial class LIUpdateTask : Form
    {
        public string TableUser { get; set; }
        public int L_ID { get; set; }
        public int task_ID { get; set; }

        public LIUpdateTask()
        {
            InitializeComponent();
        }

        private void LIUpdateTask_Load(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            string Name = tname.Text;
            string description = tdesc.Text;
            string deadline = tdead.Text;

            string connectionString = "Data Source=DESKTOP-KSANB9N\\SQLEXPRESS;Initial Catalog=\"TA/LD Management System\";Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "exec LUpdateTask @tid, @tname, @tdesc, @td";
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@tid", task_ID);
                command.Parameters.AddWithValue("@tname", Name);
                command.Parameters.AddWithValue("@tdesc", description);
                command.Parameters.AddWithValue("@td", deadline);

                int rowsaffected = command.ExecuteNonQuery();

                if (rowsaffected > 0)
                {
                    MessageBox.Show("Update Successful " + Name);
                    LabInstructorLDTask ct = new LabInstructorLDTask();
                    ct.TableUser = TableUser;
                    ct.L_ID = L_ID;
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


        private void backfromcreateaccount_Click(object sender, EventArgs e)
        {
            LabInstructorLDTask lt = new LabInstructorLDTask();
            lt.TableUser = TableUser;
            lt.L_ID = L_ID;
            lt.task_ID = task_ID;
            lt.Show();
            this.Hide();
        }
    }
}

