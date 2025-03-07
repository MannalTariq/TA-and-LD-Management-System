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
    public partial class LabInstructorView : Form
    {

        public string TableUser { get; set; }
        public int L_ID { get; set; }
        public LabInstructorView()
        {
            InitializeComponent();
        }

        private void LabInstructorView_Load(object sender, EventArgs e)
        {
            LoadCIntDetails();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void LoadCIntDetails()
        {
            string connectionString = "Data Source=DESKTOP-KSANB9N\\SQLEXPRESS;Initial Catalog=\"TA/LD Management System\";Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT concat(FName, ' ' ,LName) as Name,Email,Phone  FROM Teacher where username =" + "'" + TableUser + "' AND typ = 'Lab Instructor'";
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


        private void viewSection_Click(object sender, EventArgs e)
        {
            LabInstructorSections cs = new LabInstructorSections();
            cs.TableUser = TableUser;
            cs.L_ID = L_ID;
            cs.Show();
            this.Hide();
        }

        private void viewTasks_Click(object sender, EventArgs e)
        {
            LabInstructorLDTask t = new LabInstructorLDTask();
            t.TableUser = TableUser;
            t.L_ID = L_ID;
            t.Show();
            this.Hide();
        }

        private void viewLd_Click(object sender, EventArgs e)
        {
            LabInstructorLD cs = new LabInstructorLD();
            cs.TableUser = TableUser;
            cs.L_ID = L_ID;
            cs.Show();
            this.Hide();
        }

        private void backfromLabIntView_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            this.Hide();
        }

        private void MarkAttendance_Click(object sender, EventArgs e)
        {
            AttendanceView adv= new AttendanceView();
            adv.TableUser = TableUser;
            adv.L_ID = L_ID;
            adv.Show();
            this.Hide();
        }
    }
}
