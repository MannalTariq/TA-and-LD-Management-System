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
    public partial class CourseInstructorView : Form
    {

        public string TableUser { get; set; }
        public int C_ID { get; set; }

        public CourseInstructorView()
        {
            InitializeComponent();
        }
        

        private void backfromCourseIntView_Click(object sender, EventArgs e)
        {
            LoginForm form = new LoginForm();
            form.Show();
            this.Hide();
        }

        public void LoadCIntDetails()
        {
            string connectionString = "Data Source=DESKTOP-KSANB9N\\SQLEXPRESS;Initial Catalog=\"TA/LD Management System\";Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT concat(FName, ' ' ,LName) as Name,Email,Phone  FROM Teacher where username =" + "'" + TableUser + "' AND typ = 'Course Instructor'";
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

        private void CourseInstructorView_Load(object sender, EventArgs e)
        {
            LoadCIntDetails();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void viewSection_Click(object sender, EventArgs e)
        {
            CourseInstructorSections cs = new CourseInstructorSections();
            cs.TableUser = TableUser;
            cs.C_ID = C_ID;
            cs.Show();
            this.Hide();
        }

        private void viewTA_Click(object sender, EventArgs e)
        {
            CourseInstructorTA cs = new CourseInstructorTA();
            cs.TableUser = TableUser;
            cs.C_ID = C_ID;
            cs.Show();
            this.Hide();
        }

        private void viewTasks_Click(object sender, EventArgs e)
        {
            CourseInstructorTATasks t = new CourseInstructorTATasks();
            t.TableUser = TableUser;
            t.C_ID = C_ID;
            t.Show();
            this.Hide();
        }
    }
    }
