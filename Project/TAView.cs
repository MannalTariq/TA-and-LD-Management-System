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
    public partial class TAView : Form
    {
        public string TableUser { get; set; }
        public int TA_ID { get; set; } 
        
        private  TA_Tasks_View form;


        public TAView()
        {
            InitializeComponent();
        
        }

        private void viewTask_Click(object sender, EventArgs e)
        {
            form = new TA_Tasks_View();
            form.TableUser = TableUser;
            form.TA_ID = TA_ID;
            form.Show();
        
            this.Hide();
        }

        public void LoadTADetails()
        {
            string connectionString = "Data Source=DESKTOP-KSANB9N\\SQLEXPRESS;Initial Catalog=\"TA/LD Management System\";Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT concat(FName, ' ' ,LName) as Name,Email,Phone, DOB  FROM Teacher_Assistant where username =" + "'" + TableUser + "'";
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;


            string teacherquery = "Select TA_ID FROM Teacher_Assistant WHERE Username = " + "'" + TableUser + "'";
          
            SqlCommand commandT = new SqlCommand(teacherquery, connection);
            SqlDataReader TAreader = commandT.ExecuteReader();

            if (TAreader.Read())
            {
                
                TA_ID = Convert.ToInt32(TAreader["TA_ID"]);
              
            }
            else
            {

                MessageBox.Show("TA ID not found.");
                return;
            }

            TAreader.Close();
            connection.Close();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void backfromTAView_Click(object sender, EventArgs e)
        {
             LoginForm form = new LoginForm();
             form.Show();
             this.Hide();
          
        }

        private void TAView_Load(object sender, EventArgs e)
        {
            LoadTADetails();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void viewSection_Click(object sender, EventArgs e)
        {
            CourseSec cs = new CourseSec();
            cs.TableUser = TableUser;
            cs.TA_ID = TA_ID;
            cs.Show();
            this.Hide();
        }

        private void viewSalary_Click(object sender, EventArgs e)
        {
            TA_Salary sal= new TA_Salary();
            sal.TA_ID=TA_ID;
            sal.TableUser = TableUser;
            sal.Show();
            this.Hide();
        }
    }
}
